using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace WindowsFormsApp2
{
    public partial class StudentDetailForm : Form
    {

        public int recordID=-1;
        public StudentDetailForm()
        {
            InitializeComponent();
        }

        private void StudentDetail_Load(object sender, EventArgs e)
        {
            if (recordID < 0)
                this.Close();
            loadUserByID();
        }

        public void loadUserByID()
        {
            try
            {
                using(SQLiteConnection con = new SQLiteConnection("Data Source = students.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "Select * from exams where id=@id";
                    cmd.Parameters.AddWithValue("@id",recordID);
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    if (!dataReader.HasRows)
                    {
                        dataReader.Close();
                        con.Close();
                        MessageBox.Show("User Not Found!");
                        this.Close();
                        return;
                    }

                    dataReader.Read();

                    lblID.Text = dataReader["id"].ToString();
                    txtFirstName.Text = dataReader["first_name"].ToString();
                    txtLastName.Text = dataReader["last_name"].ToString();
                    txtStudentID.Text = dataReader["student_id"].ToString();
                    txtGrade.Text = dataReader["grade"].ToString();
                    cmbExamName.SelectedItem = dataReader["exam"].ToString();
                    dataReader.Close();
                    con.Close();
                }
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = students.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "UPDATE exams SET first_name=@first_name, last_name=@last_name, student_id=@student_id, exam=@exam, grade=@grade";
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@exam", cmbExamName.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@grade", int.Parse(txtGrade.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Updated!!");
                    this.Close();
                   
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
