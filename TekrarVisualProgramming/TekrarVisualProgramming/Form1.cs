using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekrarVisualProgramming
{
    public partial class Form1 : Form
    {
        string dbFileName = "tekrar.db";
        string connectionString = @"URI=file:" + Application.StartupPath + "\\user_login_test.db";

        public Form1()
        {
            InitializeComponent();
        }
        private void getNumbersFromDatabase()
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbFileName);
            con.Open();
            try
            {
                SQLiteCommand com = new SQLiteCommand(con);
                com.CommandText = "Select * from first_table";
                SQLiteDataReader reader = com.ExecuteReader();
                if(!reader.HasRows) 
                {
                    MessageBox.Show("We dont have any numbers");
                    reader.Close(); 
                    con.Close();
                    return;
                }
               
                    while(reader.Read()) 
                    {
                        int number1 = reader.GetInt32(0);
                        cmbbox1.Items.Add(number1);
                    }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }
        private void CreateDataBase()
        {
            if(!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
                using(SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbFileName)) 
                {
                    connection.Open();
                    string sql1 = "create table first_table(number1 INTEGER NOT NULL)";
                    SQLiteCommand command = new SQLiteCommand(sql1,connection);
                    command.ExecuteNonQuery();
                    connection.Close(); 

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
            getNumbersFromDatabase();

        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
           SQLiteConnection connection1 = new SQLiteConnection(@"Data Source = " + dbFileName);
            connection1.Open();
           SQLiteCommand command1 = new SQLiteCommand(connection1);
            

            try
            {
                command1.CommandText= "INSERT INTO first_table(number1) values(@number1)";
                int number1= int.Parse(txtBox1.Text);
                command1.Parameters.AddWithValue("@number1", number1); 
                command1.ExecuteNonQuery();
                MessageBox.Show(number1 +" added");
                cmbbox1.Items.Add(number1);


                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex.Message);
            }
            connection1.Close();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if(cmbbox1.SelectedIndex < 0) 
            {
                return;
            }
            int selectednumber = int.Parse(cmbbox1.SelectedItem.ToString());

            SQLiteConnection con1 = new SQLiteConnection(@"Data Source = " + dbFileName);
            con1.Open();
            try
            {
                SQLiteCommand com1 = new SQLiteCommand(con1);
                com1.CommandText = "Delete from first_table where number1=@number1";
                com1.Parameters.AddWithValue("@number1",selectednumber);
                com1.ExecuteNonQuery();
                MessageBox.Show(selectednumber + " deleted");
                cmbbox1.Items.RemoveAt(cmbbox1.SelectedIndex);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            con1.Close();   
        }
    }
}
