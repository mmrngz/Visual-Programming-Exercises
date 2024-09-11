using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week11importantcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet2.students_table' table. You can move, or remove it, as needed.
            this.students_tableTableAdapter.Fill(this.studentsDataSet2.students_table);

        }
       /* private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show(e.ColumnIndex + " - " + e.RowIndex);
                if (e.ColumnIndex == 4 && e.RowIndex >= 0)
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    StudentDetailForm frmStudentDetail = new StudentDetailForm();
                    frmStudentDetail.recordID = id;
                    frmStudentDetail.ShowDialog();
                }
            }
            catch (Exception exc)
            {

            }
        }*/
        // sqlite yerine sql kullanıyoruz SQLiteConnection yazmak yerine SqlConnection yazıyorum SQLiteCommand yazmak yerine SqlCommand yazıyorum command oluştururken
        //      parantez içine connectionı atıyorduk artık cmd.connection=connection; şeklinde yapıyoruz. 
        //  if (connection.State != ConnectionState.Open)
        //               connection.Open();
        // bu şekilde bir yapımız var
    }
}
