using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_4
{
    public delegate void LogoutDelegate();
    public partial class Form2 : Form
    {
        public event LogoutDelegate LogoutEvent;
        public User user;
        public Form2()
        {
            InitializeComponent();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LogoutEvent();
        }

        public void fillUserProfile()
        {
            lblID.Text = user.id.ToString();
            lblEmail.Text = user.email;
            lblPassword.Text = user.password;
            lblName.Text = user.name;
            lblAddress.Text = user.address;
            lblAge.Text = user.age.ToString();
        }


        public void addNewRecord(string bookName, string author, int pageCount)
        {
            try
            {
                using(SQLiteConnection con = new SQLiteConnection(@"Data Source = users.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO user_books(user_id,book_name,author,page_count) VALUES(@user_id,@book_name,@author,@page_count)";
                    cmd.Parameters.AddWithValue("@user_id",user.id);
                    cmd.Parameters.AddWithValue("@book_name",bookName);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@page_count", pageCount);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Record is added");
                    con.Close();
                    getAllRecordsFromDB();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            fillUserProfile();
            getAllRecordsFromDB();
        }

        public void getAllRecordsFromDB()
        {
            try
            {
                using(SQLiteConnection con = new SQLiteConnection(@"Data Source = users.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "SELECT * FROM user_books WHERE user_id=@user_id";
                    cmd.Parameters.AddWithValue("@user_id",user.id);
                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Book Name");
                    dt.Columns.Add("Author");
                    dt.Columns.Add("Page Count");

                    while(dataReader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = dataReader["id"].ToString();
                        row["Book Name"] = dataReader["book_name"].ToString();
                        row["Author"] = dataReader["author"].ToString();
                        row["Page Count"] = dataReader["page_count"].ToString();
                        dt.Rows.Add(row);
                    }

                    dataGridView1.DataSource = dt;

                    dataReader.Close();
                    con.Close();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void newBookRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRecordForm newRecordForm = new NewRecordForm();
            newRecordForm.NewRecordEvent += addNewRecord;
            newRecordForm.ShowDialog();
        }
    }
}
