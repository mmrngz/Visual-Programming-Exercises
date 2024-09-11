using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab9VisualMine
{
    public partial class Form1 : Form
    {
        string dbFileName = "users.db";
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateDataBase() 
        {
            if(!File.Exists(dbFileName)) 
            {
                SQLiteConnection.CreateFile(dbFileName);    

                using (SQLiteConnection conn = new SQLiteConnection(@"Data Source = " + dbFileName))
                {
                    conn.Open();
                    string sql1 = "create table user_table(firstname TEXT ,lastname TEXT)";
                    SQLiteCommand com = new SQLiteCommand(sql1,conn);
                    com.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            {
                Debug.WriteLine("Database is Already Created");
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDataBase();   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                return;
            SQLiteConnection conn = new SQLiteConnection(@"Data Source = " + dbFileName);
            conn.Open();
            try
            {
                SQLiteCommand comm = new SQLiteCommand(conn);
                comm.CommandText = "INSERT INTO user_table(firstname,lastname) values(@firstname,@lastname)";
                string firstname=textBox1.Text.ToString();
                string lastname=textBox2.Text.ToString();
                comm.Parameters.AddWithValue("@firstname",firstname);
                comm.Parameters.AddWithValue("@lastname", lastname);
                comm.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : "+ex.Message);
            }
            conn.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
           

            SQLiteConnection conn = new SQLiteConnection(@"Data Source = " + dbFileName);
            conn.Open();
            try
            {
                SQLiteCommand comm = new SQLiteCommand(conn);
                comm.CommandText = "Select * from user_table where firstname=@firstname";
                comm.Parameters.AddWithValue("@firstname",textBox1.Text);
                SQLiteDataReader reader = comm.ExecuteReader();
                if(!reader.HasRows) return;
                reader.Read();
                string lastname=reader.GetString(1);
                textBox2.Text = lastname;
                MessageBox.Show("LastName: "+lastname);

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }
    }
}
