using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Week10LabMine
{
    public partial class Form1 : Form
    {
        public string DbName = "users1week10.db";
        public Form1()
        {

            InitializeComponent();
        }
        public void CreateDataBase() 
        {
            if (!File.Exists(DbName)) 
            {
                SQLiteConnection.CreateFile(DbName);
                using(SQLiteConnection con = new SQLiteConnection(@"Data Source = " + DbName)) 
                {
                    con.Open();
                    SQLiteCommand com = new SQLiteCommand(con);
                    com.CommandText = "CREATE TABLE users1week10(id INTEGER NOT NULL UNIQUE, email TEXT NOT NULL UNIQUE, password TEXT NOT NULL, name TEXT NOT NULL, address TEXT, age INTEGER, PRIMARY KEY(id AUTOINCREMENT)) ";
                    com.ExecuteNonQuery();
                    com.CommandText = "CREATE TABLE users1week10_books(id INTEGER NOT NULL UNIQUE, users1week10_id INTEGER NOT NULL, book_name TEXT NOT NULL, author TEXT NOT NULL, page_count INTEGER NOT NULL, PRIMARY KEY(id AUTOINCREMENT), FOREIGN KEY(usersweek10_id) REFERENCES users1week10(id))";
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using(SQLiteConnection con = new SQLiteConnection(@"Data Source = " + DbName)) 
                {
                    con.Open() ;
                    SQLiteCommand com = new SQLiteCommand(con);
                    com.CommandText = "INSERT INTO users1week10(email,password,name,address,age) VALUES(@email,@password,@name,@address,@age)";
                    com.Parameters.AddWithValue("@email",txtregisteremail.Text);
                    com.Parameters.AddWithValue("@password",txtregisterpassword.Text);
                    com.Parameters.AddWithValue("@name",txtregistername.Text);
                    com.Parameters.AddWithValue("@address",txtregisteraddress.Text);
                    com.Parameters.AddWithValue("@age",int.Parse(txtregisterage.Text));
                    com.ExecuteNonQuery();  
                    tabControl1.SelectedIndex = 0;
                    MessageBox.Show("Kayit Yapildi");
                    con.Close() ;   

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex.Message);
            }
        }
        public void logout() 
        {
            this.Visible = true;
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + DbName))
                {
                    con.Open(); 
                    SQLiteCommand com = new SQLiteCommand(con);
                    com.CommandText = "SELECT * FROM users1week10 WHERE email=@email AND password=@password";
                    com.Parameters.AddWithValue("@email",txtsignemail.Text);
                    com.Parameters.AddWithValue("@password",txtsignpassword.Text);    
                    SQLiteDataReader reader=com.ExecuteReader();    
                    if(!reader.HasRows) 
                    {
                        reader.Close();
                        con.Close();

                        MessageBox.Show("Okunacak Veri Yok");
                        return;
                    }
                    reader.Read();
                    int id = int.Parse(reader["id"].ToString());
                    int age= int.Parse(reader["age"].ToString());   
                    string email= reader["email"].ToString();   
                    string password= reader["password"].ToString(); 
                    string address= reader["address"].ToString();   
                    string name= reader["name"].ToString(); 
                    
                    User loguser= new User(id, email, password,name,address,age);  

                    this.Visible = false;
                    reader.Close();
                    con.Close() ; 

                    Form2 form3 = new Form2();
                    form3.user = loguser;
                    form3.ManageLogout += logout;
                    form3.ShowDialog();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDataBase();
        }
    }
}
