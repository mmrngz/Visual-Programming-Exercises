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
    public delegate void UpdateProfileDelegate(User updateduser);
    public partial class UpdateProfileForm : Form
    {
        public event UpdateProfileDelegate UpdateProfile;
        public User updateduser;
        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        private void btnupdateprofile_Click(object sender, EventArgs e)
        {
            updateduser.name=txtupdatename.Text;    
            updateduser.email=txtupdateemail.Text;
            updateduser.password=txtupdatepassword.Text;    
            updateduser.address=txtupdateadress.Text;
            updateduser.age = int.Parse(txtupdateage.Text);
            UpdateProfile(updateduser); 
        }

        private void UpdateProfileForm_Load(object sender, EventArgs e)
        {
            txtupdatename.Text = updateduser.name;
            txtupdateemail.Text = updateduser.email;
            txtupdatepassword.Text = updateduser.password;
            txtupdateadress.Text = updateduser.address;
            txtupdateage.Text=updateduser.age.ToString();


        }
    }
}
