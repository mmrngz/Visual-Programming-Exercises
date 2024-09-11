using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualProgramming6Week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            cmbbox1.Items.Add(txtname.Text);   
            txtname.Text = "";    
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            int index = cmbbox1.Items.IndexOf(txtname.Text);    

            if (index == -1)
            {
                MessageBox.Show("Not Found!");
                return;
            }
            
            cmbbox1.Items.RemoveAt(index);
            MessageBox.Show("Removed!");

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int cmbindex= cmbbox1.SelectedIndex;
            string cmbitem = cmbbox1.SelectedItem.ToString();
            MessageBox.Show("Index : "+cmbindex+"  Item: "+cmbitem);
        }

        private void btndecrease_Click(object sender, EventArgs e)
        {
            int result1= cmbbox1.SelectedIndex - 1;
            cmbbox1.SelectedIndex = result1 < 0 ? 0 : result1;
        }

        private void btnincrease_Click(object sender, EventArgs e)
        {
            int result1 = cmbbox1.SelectedIndex + 1;
            int maxindex = cmbbox1.Items.Count - 1;
            cmbbox1.SelectedIndex= result1 >= maxindex ? maxindex : result1;
        }

        private void cmbbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Changed!");
        }









        private void btnAddListBox_Click(object sender, EventArgs e)
        {
            if (txtname1.Text == "" || txtage1.Text=="" || txtemail1.Text=="" ) 
            {
                MessageBox.Show("Tüm Alanları Doldurmanız Zorunludur");
                return; 
            }
            listBox1.Items.Add(txtname1.Text+","+txtage1.Text + "," +txtemail1.Text);
            txtname1.Text = "";
            txtage1.Text = "";
            txtemail1.Text = "";

            
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw= new StreamWriter(@"C:\Users\maran\OneDrive\Masaüstü\pilots.txt", true);
            foreach (string s in listBox1.Items) 
            {
                sw.WriteLine(s);
            }
            sw.Close();
            listBox1.Items.Clear(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection= domainUpDown1.Items;
            collection.Add("February");
            collection.Add("March");
            collection.Add("Aughst");
            domainUpDown1.Text = "February";
            numericUpDown2.Maximum = 2023;
            

        }

        private void btnBirthDate_Click(object sender, EventArgs e)
        {
            lblbdate.Text=numericUpDown1.Value.ToString()+"  " + domainUpDown1.Text + "  " + numericUpDown2.Value.ToString();
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check= (CheckBox)sender;
            if (check.Checked )
            {
                listBox2.Items.Add(check.Text);
            }
            else
            {
                listBox2.Items.Remove(check.Text);
            }
        }
    }
}
