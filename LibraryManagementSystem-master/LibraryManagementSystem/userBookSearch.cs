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
    public partial class userBookSearch : Form
    {
        SqlConnection con;
        SqlCommand cmd ;

        // userid and pwd
        public int userid;
        public string password;

        private void userBookSearch_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "libraryDBDataSet.book_id". Sie können sie bei Bedarf verschieben oder entfernen.
            this.book_idTableAdapter.Fill(this.libraryDBDataSet.book_id);
            // copy userid and pwd
            userid = login.userid;
            password = login.password;

            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // on intialise display books table
            cmd = new SqlCommand("SELECT * FROM book_id INNER JOIN user_id ON book_id.ID = user_id.ID where user_id.ID = " + Session.userid, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            userBookSearchDgv.DataSource = ds.Tables[0];

            // make dgv read only
            userBookSearchDgv.ReadOnly = true;

            // select both radio button by default
            userBookSearchRbBoth.Select();
        }

        private void UserBookSearchBtnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            if(userBookSearchRbBoth.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM book_id INNER JOIN user_id ON book_id.ID = user_id.ID where user_id.ID = " + Session.userid, con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + UserBookSearchTbxQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                userBookSearchDgv.DataSource = ds.Tables[0];
            }
            else if (userBookSearchRbTitle.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM book_id INNER JOIN user_id ON book_id.ID = user_id.ID where user_id.ID = " + Session.userid, con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + UserBookSearchTbxQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                userBookSearchDgv.DataSource = ds.Tables[0];
            }
            else if(userBookSearchRbAuthor.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM book_id INNER JOIN user_id ON book_id.ID = user_id.ID where user_id.ID = " + Session.userid, con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + UserBookSearchTbxQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                userBookSearchDgv.DataSource = ds.Tables[0];
            }
        }

        private void userBookSeacrhBtnChangePassword_Click(object sender, EventArgs e)
        {
            // hide current form and show next

            this.Hide();
            changePassword cp = new changePassword();
            cp.Show();
        }

        private void UserBookSearchBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        public userBookSearch()
        {
            InitializeComponent();

            
        }

        private void usrBookSearchBtnIssuedBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            usrIssuedBooks uib = new usrIssuedBooks();
            uib.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userBookSearchDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
