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

namespace LibraryManagementSystem
{
    public partial class admEditStudentDB : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        
        // selected book id
        int selected_user_id;

        private void admEditStudentDB_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "libraryDBDataSet11.customer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.customerTableAdapter6.Fill(this.libraryDBDataSet11.customer);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "libraryDBDataSet10.customer". Sie können sie bei Bedarf verschieben oder entfernen.
                    displayUsers();
        }

        public admEditStudentDB()
        {
            InitializeComponent();
        }

        public void displayUsers()
        {
            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // on intialise display books table
            cmd = new SqlCommand("SELECT * FROM customer", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            editStudentDBDgvTable.DataSource = ds.Tables[0];
            editStudentDBDgvTable.ReadOnly = true;

            // add sort functionality to admin column
            editStudentDBDgvTable.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        public void clearFields()
        {
            editStudentDBTbxUserID.Text = string.Empty;
            admStudentDBTbxName.Text = string.Empty;
            editStudentDBTbxAddress.Text = string.Empty;
            editStudentDBTbxPassword.Text = string.Empty;
            editStudentDBTbxEmail.Text = string.Empty;
            admStudentDBCbAdmin.Checked = false;
        }

        private void editStudentDBBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void editStudentDBBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        // search functionality
        private void editStudentDBBtnSearch_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Closed)
                con.Open();

            try
            {
                // try to check if search query is number
                int user_id = int.Parse(editStudentDBTbxSearch.Text);
                cmd = new SqlCommand("select * FROM customer", con);
                cmd.Parameters.AddWithValue("@searchQuery", user_id);
            }
            catch
            {
                // go with it not a number
                cmd = new SqlCommand("SELECT * FROM customer", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + editStudentDBTbxSearch.Text + "%");
            }
            

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            editStudentDBDgvTable.DataSource = ds.Tables[0];
            
        }

        // cell click event
        private void editStudentDBDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // remove column headers
            if(e.RowIndex != -1 && e.RowIndex != editStudentDBDgvTable.Rows.Count - 1 )
            {
                // copy value to variable even if unnecessary
                selected_user_id = Convert.ToInt32(editStudentDBDgvTable.Rows[e.RowIndex].Cells[0].Value);
                bool admin = Convert.ToBoolean(editStudentDBDgvTable.Rows[e.RowIndex].Cells[1].Value);
                string name = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[2].Value);
                string address = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[3].Value);
                string password = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[4].Value);
                string email = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[5].Value);

                // paste into textbox
                editStudentDBTbxUserID.Text = Convert.ToString(selected_user_id);
                admStudentDBCbAdmin.Checked = admin;
                admStudentDBTbxName.Text = name;
                editStudentDBTbxAddress.Text = address;
                editStudentDBTbxPassword.Text = password;
                editStudentDBTbxEmail.Text = email;
            }
        }

        // CLEAR BUTTON
        private void admEditStudentDBBtnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // SAVE EDIT BUTTON
        private void editStudentDBBtnSave_Click(object sender, EventArgs e)
        {
            // variables 
            int user_id = 0;
            bool admin;
            string name;
            string address;
            string password;
            string email;

            bool preliminaryAcceptedState = true;

            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // copy values
            // copy value to variable even make sure correct format
            try
            {
                user_id = Convert.ToInt32(editStudentDBTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the UserID is an interger.");
                preliminaryAcceptedState = false;
            }
            admin = admStudentDBCbAdmin.Checked;
            name = admStudentDBTbxName.Text;
            address = editStudentDBTbxAddress.Text;
            password = editStudentDBTbxPassword.Text;
            email = editStudentDBTbxEmail.Text;

            // try to edit users only if all pevious info is healthy
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand(@"UPDATE customer SET admin = @admin, vorname = @vorname, address = @address, password = @password, email = @email WHERE user_id = @selected_user_id", con);
                    cmd.Parameters.AddWithValue("@admin", admin);
                    cmd.Parameters.AddWithValue("@vorname", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@selected_user_id", selected_user_id);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Changes successfully saved.");
                        clearFields();
                    }

                    // display updated books
                    displayUsers();
                } 
                catch
                {
                    MessageBox.Show("There is already a user with this UserID.\nUserID's have to be distinct.");
                }
            }
        }

        // ADD TO DB BUTTON
        private void editStudentDBBtnAddToDB_Click(object sender, EventArgs e)
        {
            // variables 
            int user_id = 0;
            bool admin;
            string name;
            string address;
            string password;
            string email;

            bool preliminaryAcceptedState = true;

            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // copy values
            // copy value to variable even make sure correct format
            try
            {
                user_id = Convert.ToInt32(editStudentDBTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the UserID is an interger.");
                preliminaryAcceptedState = false;
            }
            admin = admStudentDBCbAdmin.Checked;
            name = admStudentDBTbxName.Text;
            address = editStudentDBTbxAddress.Text;
            password = editStudentDBTbxPassword.Text;
            email = editStudentDBTbxEmail.Text;

            // try to edit users only if all pevious info is healthy
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO customer(admin, vorname, address, password, email) VALUES(@admin, @vorname, @address, @password, @email)", con);
                    cmd.Parameters.AddWithValue("@admin", admin);
                    cmd.Parameters.AddWithValue("@vorname", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("User successfully added.");
                        clearFields();
                    }

                    // display updated books
                    displayUsers();
                }
                catch
                {
                    MessageBox.Show("There is already a user with this UserID.\nUserID's have to be distinct.");
                }
            }
        }

        private void editStudentDBBtnDelete_Click(object sender, EventArgs e)
        {
            // variables 
            int id = 0;

            bool preliminaryAcceptedState = true;

            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // copy values
            // copy value to variable even make sure correct format
            try
            {
                id = Convert.ToInt32(editStudentDBTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the UserID is an interger.");
                preliminaryAcceptedState = false;
            }

            // try to edit users only if all pevious info is healthy
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("DELETE FROM customer WHERE user_id = @user_id", con);
                    cmd.Parameters.AddWithValue("@user_id", id);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("User successfully deleted.");
                        clearFields();
                    }

                    // display updated books
                    displayUsers();
                }
                catch
                {
                    MessageBox.Show("Cannot delete a user with an issued book.\nPlease make sure that he has returned the book before deleting him.");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editStudentDBDgvTable_AlternatingRowsDefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void editStudentDBDgvTable_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        private void editStudentDBTbxUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void editStudentDBDgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admStudentDBTbxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
