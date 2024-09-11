namespace Week10LabMine
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtsignpassword = new System.Windows.Forms.TextBox();
            this.btnsign = new System.Windows.Forms.Button();
            this.txtsignemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtregisterage = new System.Windows.Forms.TextBox();
            this.txtregisteraddress = new System.Windows.Forms.TextBox();
            this.txtregistername = new System.Windows.Forms.TextBox();
            this.txtregisterpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtregisteremail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 447);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtsignpassword);
            this.tabPage1.Controls.Add(this.btnsign);
            this.tabPage1.Controls.Add(this.txtsignemail);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sign";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtsignpassword
            // 
            this.txtsignpassword.Location = new System.Drawing.Point(129, 98);
            this.txtsignpassword.Name = "txtsignpassword";
            this.txtsignpassword.Size = new System.Drawing.Size(100, 22);
            this.txtsignpassword.TabIndex = 5;
            // 
            // btnsign
            // 
            this.btnsign.Location = new System.Drawing.Point(129, 146);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(100, 34);
            this.btnsign.TabIndex = 4;
            this.btnsign.Text = "Log In";
            this.btnsign.UseVisualStyleBackColor = true;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // txtsignemail
            // 
            this.txtsignemail.Location = new System.Drawing.Point(129, 51);
            this.txtsignemail.Name = "txtsignemail";
            this.txtsignemail.Size = new System.Drawing.Size(100, 22);
            this.txtsignemail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRegister);
            this.tabPage2.Controls.Add(this.txtregisterage);
            this.tabPage2.Controls.Add(this.txtregisteraddress);
            this.tabPage2.Controls.Add(this.txtregistername);
            this.tabPage2.Controls.Add(this.txtregisterpassword);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtregisteremail);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(169, 246);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 44);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtregisterage
            // 
            this.txtregisterage.Location = new System.Drawing.Point(169, 188);
            this.txtregisterage.Name = "txtregisterage";
            this.txtregisterage.Size = new System.Drawing.Size(100, 22);
            this.txtregisterage.TabIndex = 11;
            // 
            // txtregisteraddress
            // 
            this.txtregisteraddress.Location = new System.Drawing.Point(169, 147);
            this.txtregisteraddress.Name = "txtregisteraddress";
            this.txtregisteraddress.Size = new System.Drawing.Size(100, 22);
            this.txtregisteraddress.TabIndex = 10;
            // 
            // txtregistername
            // 
            this.txtregistername.Location = new System.Drawing.Point(169, 22);
            this.txtregistername.Name = "txtregistername";
            this.txtregistername.Size = new System.Drawing.Size(100, 22);
            this.txtregistername.TabIndex = 9;
            // 
            // txtregisterpassword
            // 
            this.txtregisterpassword.Location = new System.Drawing.Point(169, 103);
            this.txtregisterpassword.Name = "txtregisterpassword";
            this.txtregisterpassword.Size = new System.Drawing.Size(100, 22);
            this.txtregisterpassword.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Age :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name :";
            // 
            // txtregisteremail
            // 
            this.txtregisteremail.Location = new System.Drawing.Point(169, 57);
            this.txtregisteremail.Name = "txtregisteremail";
            this.txtregisteremail.Size = new System.Drawing.Size(100, 22);
            this.txtregisteremail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.TextBox txtsignemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtregisteremail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsignpassword;
        private System.Windows.Forms.TextBox txtregisterage;
        private System.Windows.Forms.TextBox txtregisteraddress;
        private System.Windows.Forms.TextBox txtregistername;
        private System.Windows.Forms.TextBox txtregisterpassword;
        private System.Windows.Forms.Button btnRegister;
    }
}

