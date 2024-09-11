using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string dbName = "students.db";
        SQLiteConnection connection = new SQLiteConnection(@"Data Source = students.db");
        
        public Form1()
        {
            InitializeComponent();
        }

        public void createDatabase()
        {
            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "CREATE TABLE exams(id INTEGER PRIMARY KEY, first_name varchar(255) not null, last_name varchar(255) not null, student_id varchar(255) not null,  exam varchar(255) not null,grade INTEGER not null)";
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        

        public void getAllStudents()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "SELECT * FROM exams";
                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Full Name");
                    dt.Columns.Add("Exam");
                    dt.Columns.Add("Grade");


                    while (dataReader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = dataReader["id"].ToString();
                        row["Full Name"] = dataReader["first_name"].ToString() + " " + dataReader["last_name"].ToString();
                        row["Exam"] = dataReader["exam"].ToString();
                        row["Grade"] = dataReader["grade"].ToString();
                        dt.Rows.Add(row);
                    }


                    dataGridView1.DataSource = dt;
                    DataGridViewButtonColumn bc = new DataGridViewButtonColumn();
                    bc.HeaderText = "Action";
                    bc.Text = "Details";
                    bc.Name = "btnDetails";
                    bc.UseColumnTextForButtonValue = true;
                    bc.Width = 100;
                    dataGridView1.Columns.Add(bc);


                    dataReader.Close();
                    con.Close();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            createDatabase();
            getAllStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using(SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO exams(first_name,last_name,student_id,exam,grade) VALUES(@first_name,@last_name,@student_id,@exam,@grade)";
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@exam", cmbExamName.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@grade", int.Parse(txtGrade.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Inserted");
                }

            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show(e.ColumnIndex+" - " + e.RowIndex);
                if (e.ColumnIndex == 4 && e.RowIndex >= 0)
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    StudentDetailForm frmStudentDetail = new StudentDetailForm();
                    frmStudentDetail.recordID = id;
                    frmStudentDetail.ShowDialog();
                }
            }catch(Exception exc)
            {

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getAllStudents();
        }
    }
}
