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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VisualProgrammingWeek6Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        

        private void btnsign_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string pwd = txtpwd.Text;
            StreamReader reader = new StreamReader(@"C:\Users\maran\OneDrive\Belgeler\admins.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] adminArray = line.Split(',');
                if (adminArray.Length == 3 && adminArray[0] == email && adminArray[1] == pwd)
                {
                    MessageBox.Show("Başarılı Giris");
                    // Kullanıcı girişi başarılı
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;

                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
