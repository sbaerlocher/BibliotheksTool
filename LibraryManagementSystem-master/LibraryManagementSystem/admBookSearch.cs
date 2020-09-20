using System;
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


using System.IO;
using ClosedXML.Excel;

namespace LibraryManagementSystem
{
    public partial class admBookSearch : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        // userid and pwd
        public int userid;
        public string password;

        public admBookSearch()
        {
            InitializeComponent();
        }

        private void admBookSearch_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "libraryDBDataSet18.books". Sie können sie bei Bedarf verschieben oder entfernen.
            this.booksTableAdapter1.Fill(this.libraryDBDataSet18.books);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "libraryDBDataSet2.books". Sie können sie bei Bedarf verschieben oder entfernen.
            // copy userid and pwd
            userid = login.userid;
            password = login.password;

            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            LoadDataGrid();

            // make read only
            admBookSearchDgv.ReadOnly = true;

            // select both radio button by default
            admBookSearchRbBoth.Select();
        }

        private void admBookSearchBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void admBookSearchBtnSearch_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            string sql = "SELECT * FROM books";

            if (!string.IsNullOrWhiteSpace(admBookSearchTbxQuery.Text))
            {
                if (admBookSearchRbBoth.Checked == true)
                {
                    sql += " WHERE author LIKE @searchQuery or title LIKE @searchquery";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@searchQuery", "%" + admBookSearchTbxQuery.Text + "%");

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    admBookSearchDgv.DataSource = ds.Tables[0];
                }
                else if (admBookSearchRbTitle.Checked == true)
                {
                    sql += " WHERE title LIKE @searchquery";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@searchQuery", "%" + admBookSearchTbxQuery.Text + "%");

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    admBookSearchDgv.DataSource = ds.Tables[0];
                }
                else if (admBookSearchRbAuthor.Checked == true)
                {
                    sql += " WHERE author LIKE @searchQuery";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@searchQuery", "%" + admBookSearchTbxQuery.Text + "%");

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    admBookSearchDgv.DataSource = ds.Tables[0];
                }
            }
            else
            {
                cmd = new SqlCommand(sql, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                admBookSearchDgv.DataSource = ds.Tables[0];
            }
        }


        private void admBookSearchBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admBookSearchDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admBookSearchTbxQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void admBookExportBtn_Click(object sender, EventArgs e)
        {
            string t_path = @"C:\Users\sbaerlocher\Desktop\test.xlsx";
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 10 * FROM books", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    XLWorkbook wb = new XLWorkbook();
                    wb.Worksheets.Add(dt, "WorksheetName");
                    wb.SaveAs(t_path);
                }
            }
        }
    } 
}
