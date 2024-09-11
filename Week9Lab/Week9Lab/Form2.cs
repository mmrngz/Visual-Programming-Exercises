using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9Lab
{
    public delegate void ManageStudentDelegate(Student student);
    public partial class Form2 : Form
    {
        public event ManageStudentDelegate stdntdelagate;
        public Student cstudent= new Student();
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(cstudent.Id == -1)
            {
               cstudent = new Student();
            }
            cstudent.Name=textBox1.Text;
            cstudent.Grade= int.Parse(textBox2.Text);

            stdntdelagate(cstudent);
            this.Close();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(cstudent.Id != -1)
            {
               textBox1.Text = cstudent.Name.ToString();
               textBox2.Text = cstudent.Grade.ToString();
                btn.Text = "Update";

               
            }

        }
    }
}
