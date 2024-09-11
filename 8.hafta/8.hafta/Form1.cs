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

namespace _8.hafta
{
    public partial class Form1 : Form
    {
        string dbFileName = "vp.db";
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
                SQLiteCommand command = new SQLiteCommand(con);
                command.CommandText = "Select * from first_table";
                SQLiteDataReader dataReader = command.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    MessageBox.Show("We don't have any numbers");
                    dataReader.Close();
                    con.Close();
                    return;
                }

                while (dataReader.Read())
                {
                    int number1 = dataReader.GetInt32(0);
                    cmb1.Items.Add(number1);
                }




            }
            catch (Exception exc)
            {
                Debug.WriteLine("Error : " + exc.Message);
            }


            con.Close();
        }

        private void createDataBase()
        {
            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
                using (var connection = new SQLiteConnection(@"Data Source = " + dbFileName))
                {
                    connection.Open();
                    string sql1 = "create table first_table(number1 INTEGER NOT NULL)";
                    SQLiteCommand cmd = new SQLiteCommand(sql1, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                Debug.WriteLine("Database is already created");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            createDataBase();
            getNumbersFromDatabase();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbFileName);
            con.Open();

            SQLiteCommand command = new SQLiteCommand(con);
            try
            {
                command.CommandText = "INSERT INTO first_table(number1) values(@number1)";
                int number1 = int.Parse(txtbox1.Text);
                command.Parameters.AddWithValue("@number1", number1);
                command.ExecuteNonQuery();
                MessageBox.Show(number1 + " added successfully");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error : " + exc.Message);
            }


            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmb1.SelectedIndex < 0)
                return;

            int selectedNumber = int.Parse(cmb1.SelectedItem.ToString());


            SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbFileName);


            connection.Open();
            try
            {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "Delete from first_table where number1=@number1";
                command.Parameters.AddWithValue("@number1", selectedNumber);
                command.ExecuteNonQuery();
                MessageBox.Show(selectedNumber + " is deleted");
                cmb1.Items.RemoveAt(cmb1.SelectedIndex);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error : " + exc.Message);
            }



            connection.Close();

        }
    }
}
