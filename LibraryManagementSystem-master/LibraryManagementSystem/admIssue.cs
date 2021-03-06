﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LibraryManagementSystem
{
    public partial class admIssue : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public admIssue()
        {
            InitializeComponent();
        }

        private void admIssue_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "libraryDBDataSet16.books". Sie können sie bei Bedarf verschieben oder entfernen.


            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // display table
            display();

            // select both radio button by default
            admIssueRbBoth.Select();
        }

        public void display()
        {
            // on intialise display books table
            //cmd = new SqlCommand("SELECT user_id as 'User ID', vorname as 'vorname', book_id as 'Book ID', title as 'Title', date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE())) as 'Days Passed' from issue, users, books where i_user_id = user_id and i_book_id = book_id", con);
            cmd = new SqlCommand("SELECT * FROM Books WHERE Lend is NULL", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            admIssueDgvTable.DataSource = ds.Tables[0];

            // make read only
            admIssueDgvTable.ReadOnly = true;
        }

        public void clearFields()
        {
            admIssueTbxSearchQuery.Text = string.Empty;
            admIssueTbxUserID.Text = string.Empty;
            amdIssueTbxBookID.Text = string.Empty;
        }

        private void admIssueDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // when not column header
            if(e.RowIndex != -1 && e.RowIndex != admIssueDgvTable.Rows.Count - 1)
            {
                amdIssueTbxBookID.Text = Convert.ToString(admIssueDgvTable.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void admIssueBtnIssue_Click(object sender, EventArgs e)
        {
            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // variables
            int user_id = 0; 
            int book_id = 0;

            bool preliminaryAcceptedState = true;

            // check credentials
            try
            {
                user_id = int.Parse(admIssueTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("User ID should be an integer.");
                preliminaryAcceptedState = false;
            }
            try
            {
                book_id = int.Parse(amdIssueTbxBookID.Text);
            }
            catch
            {
                MessageBox.Show("Book ID should be an interger.");
                preliminaryAcceptedState = false;
            }


            // check two issues
            cmd = new SqlCommand("SELECT * FROM lend WHERE Customer_ID = @user_id AND [End_date] is null", con);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            int rows = ds.Tables[0].Rows.Count;

            if(rows >= 2)
            {
                MessageBox.Show("Cannot issue more books.\nA user can only issue 2 books.");
                preliminaryAcceptedState = false;
            }

            // check someone already issued
            cmd = new SqlCommand("SELECT * FROM lend WHERE book_id = @book_id and [End_date] is null", con);
            cmd.Parameters.AddWithValue("@book_id", book_id);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

            int rows1 = ds1.Tables[0].Rows.Count;

            if(rows1 > 0)
            {
                MessageBox.Show("The book has already been issued by someone else.\nCannot issue book.");
                preliminaryAcceptedState = false;
            }

            // issue entry in table
            if(preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO lend([Customer_ID],[Book_ID],[Start_Date]) VALUES(@user_id, @book_id, CONVERT(date, GETDATE()))", con);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@book_id", book_id);

                    int result = cmd.ExecuteNonQuery();

                    if(result == 1)
                    {
                        MessageBox.Show("Book successfully issued.");
                        display();
                        clearFields();
                    }
                    cmd = new SqlCommand("UPDATE books SET Lend =  CONVERT(date, GETDATE()) WHERE Book_ID = @book_id", con);
                    cmd.Parameters.AddWithValue("@book_id", book_id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Please make sure that the the Book ID and User ID is valid.\nIf you still get an error then contact the developer.");
                }

            }
        }

        private void admIssueBtnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            if (admIssueRbBoth.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM books WHERE author LIKE @searchQuery or title LIKE @searchquery", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admIssueTbxSearchQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                admIssueDgvTable.DataSource = ds.Tables[0];
            }
            else if (admIssueRbTitle.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM books WHERE title LIKE @searchquery", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admIssueTbxSearchQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                admIssueDgvTable.DataSource = ds.Tables[0];
            }
            else if (admIssueRbAuthor.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM books WHERE author LIKE @searchQuery", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admIssueTbxSearchQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                admIssueDgvTable.DataSource = ds.Tables[0];
            }
        }

        private void admIssueBooksBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void admIssueBooksBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void amdIssueTbxBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void admIssue_Load_1(object sender, EventArgs e)
        {

        }
    }
}
