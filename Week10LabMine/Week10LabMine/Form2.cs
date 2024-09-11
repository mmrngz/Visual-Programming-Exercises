using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Week10LabMine
{
    public delegate void ManageLogoutDelegate();
    public partial class Form2 : Form
    {
        public event ManageLogoutDelegate ManageLogout;
        public User user;
        public Form2()
        {
            InitializeComponent();
        }
        public void getAllRecordsFromDb() 
        {
            try
            {
                using(SQLiteConnection conn = new SQLiteConnection(@"Data Source = users1week10.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(conn);
                    cmd.CommandText = "SELECT * FROM users1week10_books WHERE users1week10_id=@users1week10_id";
                    cmd.Parameters.AddWithValue("@users1week10_id",user.id);
                    SQLiteDataReader reader= cmd.ExecuteReader();   
                    if(!reader.HasRows) 
                    {
                        MessageBox.Show("Veri Yok !!");
                        
                        reader.Close();
                        conn.Close();
                        return; 
                    }
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("BOOK NAME");
                    dt.Columns.Add("AUTHOR");
                    dt.Columns.Add("PAGE COUNT");
                    

                    if(reader.Read()) 
                    {
                        DataRow dr = dt.NewRow();
                        dr["ID"] = int.Parse(reader["id"].ToString());
                        dr["BOOK NAME"] = reader["book_name"].ToString();
                        dr["AUTHOR"] = reader["author"].ToString() ;
                        dr["PAGE COUNT"] = int.Parse(reader["page_count"].ToString());
                        dt.Rows.Add(dr);
                    }
                    dataGridView1.DataSource = dt;  
                    reader.Close(); 
                    conn.Close() ;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }
        public void showUserProfile() 
        {
            lblid.Text = user.id.ToString();
            lblname.Text = user.name;
            lblemail.Text = user.email;
            lblpassword.Text = user.password;   
            lbladdress.Text = user.address; 
            lblage.Text = user.age.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showUserProfile();
            getAllRecordsFromDb();

            
        }
        public void Addrecord(string bookname,string author,int pagecount) 
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = users1week10.db")) 
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO users1week10_books(users1week10_id,book_name,author,page_count) VALUES(@users1week10_id,@book_name,@author,@page_count)";
                    cmd.Parameters.AddWithValue("@users1week10_id",user.id);
                    cmd.Parameters.AddWithValue("@book_name", bookname);
                    cmd.Parameters.AddWithValue ("@author",author);    
                    cmd.Parameters.AddWithValue ("@page_count", pagecount);
                    cmd.ExecuteNonQuery();
                    getAllRecordsFromDb();
                    con.Close();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageLogout();
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordForm recordForm = new RecordForm();
            recordForm.AddBook += Addrecord;
            recordForm.ShowDialog();    
        }
        public void updateProfile(User updateduser) 
        {
            this.user = updateduser;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(@"Data Source= users1week10.db"))
                {
                    conn.Open();    
                    SQLiteCommand cmd = new SQLiteCommand(conn);
                    cmd.CommandText = "UPDATE users1week10 SET email=@email,password=@password,name=@name,address=@address,age=@age WHERE id=@users1week10_id";
                    cmd.Parameters.AddWithValue("@users1week10_id",user.id);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    cmd.Parameters.AddWithValue("@address",user.address);
                    cmd.Parameters.AddWithValue("@age", user.age);
                    cmd.ExecuteNonQuery();
                    showUserProfile();
                    conn.Close();
                    MessageBox.Show("Updated");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnupdateprofile_Click(object sender, EventArgs e)
        {
            UpdateProfileForm formupdate= new UpdateProfileForm();
            formupdate.updateduser = user;,
            formupdate.UpdateProfile += updateProfile;
            formupdate.ShowDialog();
        }
    }
}
