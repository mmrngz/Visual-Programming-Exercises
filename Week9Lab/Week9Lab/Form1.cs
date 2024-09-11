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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Managestudentlist(Student student) 
        {
            if (student.Id >= 0)
                listbox1.Items[student.Id] = student.ToString();
            else
                listbox1.Items.Add(student.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.stdntdelagate += Managestudentlist;
            form2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(listbox1.SelectedIndex < 0)
            {
                return;
            }
            Form2 form2 = new Form2();
            form2.stdntdelagate += Managestudentlist;

            string[] data = listbox1.SelectedItem.ToString().Split('.');
            Student student = new Student();
            student.Id = listbox1.SelectedIndex;
            student.Name = data[0]; 
            student.Grade= int.Parse(data[1]);
            form2.cstudent= student;    




            form2.ShowDialog(); 
        }
    }
}
