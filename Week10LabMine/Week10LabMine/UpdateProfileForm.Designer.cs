namespace Week10LabMine
{
    partial class UpdateProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtupdatename = new System.Windows.Forms.TextBox();
            this.txtupdateemail = new System.Windows.Forms.TextBox();
            this.txtupdatepassword = new System.Windows.Forms.TextBox();
            this.txtupdateadress = new System.Windows.Forms.TextBox();
            this.txtupdateage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnupdateprofile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtupdatename
            // 
            this.txtupdatename.Location = new System.Drawing.Point(135, 37);
            this.txtupdatename.Name = "txtupdatename";
            this.txtupdatename.Size = new System.Drawing.Size(100, 22);
            this.txtupdatename.TabIndex = 0;
            // 
            // txtupdateemail
            // 
            this.txtupdateemail.Location = new System.Drawing.Point(135, 87);
            this.txtupdateemail.Name = "txtupdateemail";
            this.txtupdateemail.Size = new System.Drawing.Size(100, 22);
            this.txtupdateemail.TabIndex = 1;
            // 
            // txtupdatepassword
            // 
            this.txtupdatepassword.Location = new System.Drawing.Point(135, 136);
            this.txtupdatepassword.Name = "txtupdatepassword";
            this.txtupdatepassword.Size = new System.Drawing.Size(100, 22);
            this.txtupdatepassword.TabIndex = 2;
            // 
            // txtupdateadress
            // 
            this.txtupdateadress.Location = new System.Drawing.Point(135, 179);
            this.txtupdateadress.Name = "txtupdateadress";
            this.txtupdateadress.Size = new System.Drawing.Size(100, 22);
            this.txtupdateadress.TabIndex = 3;
            // 
            // txtupdateage
            // 
            this.txtupdateage.Location = new System.Drawing.Point(135, 219);
            this.txtupdateage.Name = "txtupdateage";
            this.txtupdateage.Size = new System.Drawing.Size(100, 22);
            this.txtupdateage.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Age : ";
            // 
            // btnupdateprofile
            // 
            this.btnupdateprofile.Location = new System.Drawing.Point(48, 263);
            this.btnupdateprofile.Name = "btnupdateprofile";
            this.btnupdateprofile.Size = new System.Drawing.Size(200, 73);
            this.btnupdateprofile.TabIndex = 10;
            this.btnupdateprofile.Text = "Update Profile";
            this.btnupdateprofile.UseVisualStyleBackColor = true;
            this.btnupdateprofile.Click += new System.EventHandler(this.btnupdateprofile_Click);
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 361);
            this.Controls.Add(this.btnupdateprofile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtupdateage);
            this.Controls.Add(this.txtupdateadress);
            this.Controls.Add(this.txtupdatepassword);
            this.Controls.Add(this.txtupdateemail);
            this.Controls.Add(this.txtupdatename);
            this.Name = "UpdateProfileForm";
            this.Text = "UpdateProfileForm";
            this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtupdatename;
        private System.Windows.Forms.TextBox txtupdateemail;
        private System.Windows.Forms.TextBox txtupdatepassword;
        private System.Windows.Forms.TextBox txtupdateadress;
        private System.Windows.Forms.TextBox txtupdateage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnupdateprofile;
    }
}