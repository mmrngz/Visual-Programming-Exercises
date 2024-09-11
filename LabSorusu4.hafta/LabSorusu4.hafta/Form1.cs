using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSorusu4.hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtdeminsion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtdeminsion.Text.Contains("x"))
                {

                    string strdeminsion = txtdeminsion.Text;
                    int w = int.Parse(strdeminsion.Substring(0, strdeminsion.IndexOf("x")));
                    int h = int.Parse(strdeminsion.Substring(strdeminsion.IndexOf('x') + 1));
                    Debug.WriteLine("Width:" + w);
                    Debug.WriteLine("Height:" + h);
                    ClientSize = new Size(w, h);
                    labelerror.Text = "";
                }
                else { labelerror.Text =" Wrong Format "; }   
            }
            catch(Exception ex){
                labelerror.Text = ex.Message;   
            }

            Debug.WriteLine(txtdeminsion.Text);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba","Visual Programming",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
                ,MessageBoxDefaultButton.Button3);
            timer1.Interval = 500; 
            timer1.Start();
            
            

            pictureBox1.Size = new Size(trackBarH.Value,trackBarV.Value);

             
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog3.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                BackColor = colorDialog3.Color;
               
            }
               
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthdate = dateTimePicker1.Value;
            int dayscount = (DateTime.Now - birthdate).Days;
            lblresult.Text = "You have been working for  " + dayscount + "  days.";
            lblresult.Size = new Size(100,60);

        }

        private void btnicon_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000, "Warning!!!", "You are under threat of hacking!!", ToolTipIcon.Info);
        }

  

        private void btnadd_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            tabPage.BackColor = Color.Red;
            tabPage.Text = "Custom Tab";

            Label lblMessage = new Label();
            lblMessage.Text = "Hi. Welcome to Custom Tab";
            lblMessage.ForeColor = Color.White;
            lblMessage.Font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
            lblMessage.Width = 350;
            tabPage.Controls.Add(lblMessage);




            tabControl1.TabPages.Add(tabPage);

            tabControl1.SelectedIndex = 2;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal value1 = numericUpDown1.Value;  
            lblresult2.Text = (value1 * 2).ToString();
            lblresult2.ForeColor = Color.Red;
            lblresult2.Font= new Font(Font, FontStyle.Bold);

        }

        private void btnartis_Click(object sender, EventArgs e)
        {
            decimal result = numericUpDown1.Value + numericUpDown1.Increment;
            numericUpDown1.Value= result> numericUpDown1.Maximum ? numericUpDown1.Maximum : result;


        }

        private void btnazalis_Click(object sender, EventArgs e)
        {
            decimal result = numericUpDown1.Value - numericUpDown1.Increment;
            numericUpDown1.Value = result < numericUpDown1.Minimum ? numericUpDown1.Minimum : result;   

        }

        private void btncatch_Click(object sender, EventArgs e)
        {
            timer1.Stop();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btncatch.Location = new Point(rnd.Next(0, Size.Width), rnd.Next(0, Size.Height));
            progressBar1.Value= progressBar1.Value+2 > progressBar1.Maximum ? progressBar1.Maximum : progressBar1.Value+2;
            
        }

        private void btncsharp_CheckedChanged(object sender, EventArgs e)
        {
            lblcheck.Text = btncsharp.Text;
        }

        private void btnphp_CheckedChanged(object sender, EventArgs e)
        {
            lblcheck.Text= btnphp.Text;

        }

        private void btnjava_CheckedChanged(object sender, EventArgs e)
        {
            lblcheck.Text= btnjava.Text;

        }

        private void trackBarH_Scroll(object sender, EventArgs e)
        {
          
            pictureBox1.Size = new Size(trackBarH.Value, trackBarV.Value);
        }

        private void trackBarV_Scroll(object sender, EventArgs e)
        {
            
            pictureBox1.Size = new Size(trackBarH.Value, trackBarV.Value);
        }

        private void btnaddroot_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(txtNode.Text);
            treeView1.SelectedNode.Nodes.Add(txtNode.Text);
        }

        private void btnremoveroot_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEnable.Enabled = false;
            btnEnable.Text = "Disabled";
            
        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color rndcolor = Color.FromArgb(rnd.Next(0, 266), rnd.Next(0, 255), rnd.Next(0, 255));
            BackColor= rndcolor;
        }

        private void closeTheFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtNode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string d = textBox3.Text;
        }

        private void lblcheck_Click(object sender, EventArgs e)
        {

        }
    }
}
