using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_4
{
    public delegate void NewRecordDelegate(string bookName, string author, int pageCount);
    public partial class NewRecordForm : Form
    {
        public event NewRecordDelegate NewRecordEvent;
        public NewRecordForm()
        {
            InitializeComponent();
        }

        private void NewRecordForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            this.Close();
            NewRecordEvent(txtBookName.Text, txtAuthor.Text, int.Parse(txtPageCount.Text));
        }
    }
}
