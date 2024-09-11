using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10LabMine
{
    public delegate void AddBookDelegate(string bookname,string author,int pagecount);
    public partial class RecordForm : Form
    {
        public event AddBookDelegate AddBook; 
        public RecordForm()
        {
            InitializeComponent();
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {

        }

        private void btnrecordaddbook_Click(object sender, EventArgs e)
        {
            AddBook(txtrecordbookname.Text, txtrecordauthor.Text, int.Parse(txtrecordpagecount.Text));
            this.Close();   

        }
    }
}
