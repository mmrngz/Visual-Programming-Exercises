namespace VisualProgramming6Week
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
            this.cmbbox1 = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btndecrease = new System.Windows.Forms.Button();
            this.btnincrease = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnAddListBox = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.txtname1 = new System.Windows.Forms.TextBox();
            this.txtage1 = new System.Windows.Forms.TextBox();
            this.txtemail1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblbdate = new System.Windows.Forms.Label();
            this.btnBirthDate = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkboxh = new System.Windows.Forms.CheckBox();
            this.checkboxbox = new System.Windows.Forms.CheckBox();
            this.checkboxb = new System.Windows.Forms.CheckBox();
            this.checkboxf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbbox1
            // 
            this.cmbbox1.FormattingEnabled = true;
            this.cmbbox1.Location = new System.Drawing.Point(26, 40);
            this.cmbbox1.Name = "cmbbox1";
            this.cmbbox1.Size = new System.Drawing.Size(229, 24);
            this.cmbbox1.TabIndex = 0;
            this.cmbbox1.SelectedIndexChanged += new System.EventHandler(this.cmbbox1_SelectedIndexChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(35, 12);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(175, 22);
            this.txtname.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(216, 11);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(297, 12);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(261, 41);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btndecrease
            // 
            this.btndecrease.Location = new System.Drawing.Point(342, 41);
            this.btndecrease.Name = "btndecrease";
            this.btndecrease.Size = new System.Drawing.Size(75, 23);
            this.btndecrease.TabIndex = 5;
            this.btndecrease.Text = "<";
            this.btndecrease.UseVisualStyleBackColor = true;
            this.btndecrease.Click += new System.EventHandler(this.btndecrease_Click);
            // 
            // btnincrease
            // 
            this.btnincrease.Location = new System.Drawing.Point(423, 41);
            this.btnincrease.Name = "btnincrease";
            this.btnincrease.Size = new System.Drawing.Size(75, 23);
            this.btnincrease.TabIndex = 6;
            this.btnincrease.Text = " >";
            this.btnincrease.UseVisualStyleBackColor = true;
            this.btnincrease.Click += new System.EventHandler(this.btnincrease_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(297, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 196);
            this.listBox1.TabIndex = 7;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(38, 189);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(47, 16);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Name:";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(38, 218);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(35, 16);
            this.lblage.TabIndex = 9;
            this.lblage.Text = "Age:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(38, 253);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(44, 16);
            this.lblemail.TabIndex = 10;
            this.lblemail.Text = "Email:";
            // 
            // btnAddListBox
            // 
            this.btnAddListBox.Location = new System.Drawing.Point(98, 291);
            this.btnAddListBox.Name = "btnAddListBox";
            this.btnAddListBox.Size = new System.Drawing.Size(128, 46);
            this.btnAddListBox.TabIndex = 11;
            this.btnAddListBox.Text = "Add ListBox";
            this.btnAddListBox.UseVisualStyleBackColor = true;
            this.btnAddListBox.Click += new System.EventHandler(this.btnAddListBox_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(323, 335);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(158, 40);
            this.btnSaveFile.TabIndex = 12;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // txtname1
            // 
            this.txtname1.Location = new System.Drawing.Point(98, 186);
            this.txtname1.Name = "txtname1";
            this.txtname1.Size = new System.Drawing.Size(174, 22);
            this.txtname1.TabIndex = 13;
            // 
            // txtage1
            // 
            this.txtage1.Location = new System.Drawing.Point(98, 218);
            this.txtage1.Name = "txtage1";
            this.txtage1.Size = new System.Drawing.Size(174, 22);
            this.txtage1.TabIndex = 14;
            // 
            // txtemail1
            // 
            this.txtemail1.Location = new System.Drawing.Point(98, 246);
            this.txtemail1.Name = "txtemail1";
            this.txtemail1.Size = new System.Drawing.Size(174, 22);
            this.txtemail1.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(632, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 16;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(758, 13);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 22);
            this.domainUpDown1.TabIndex = 17;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(885, 12);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 18;
            // 
            // lblbdate
            // 
            this.lblbdate.AutoSize = true;
            this.lblbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbdate.Location = new System.Drawing.Point(902, 44);
            this.lblbdate.Name = "lblbdate";
            this.lblbdate.Padding = new System.Windows.Forms.Padding(20);
            this.lblbdate.Size = new System.Drawing.Size(40, 56);
            this.lblbdate.TabIndex = 19;
            // 
            // btnBirthDate
            // 
            this.btnBirthDate.Location = new System.Drawing.Point(776, 54);
            this.btnBirthDate.Name = "btnBirthDate";
            this.btnBirthDate.Size = new System.Drawing.Size(102, 35);
            this.btnBirthDate.TabIndex = 20;
            this.btnBirthDate.Text = "Birth Date";
            this.btnBirthDate.UseVisualStyleBackColor = true;
            this.btnBirthDate.Click += new System.EventHandler(this.btnBirthDate_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(847, 122);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 212);
            this.listBox2.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkboxh);
            this.groupBox1.Controls.Add(this.checkboxbox);
            this.groupBox1.Controls.Add(this.checkboxb);
            this.groupBox1.Controls.Add(this.checkboxf);
            this.groupBox1.Location = new System.Drawing.Point(609, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkboxh
            // 
            this.checkboxh.AutoSize = true;
            this.checkboxh.Location = new System.Drawing.Point(7, 113);
            this.checkboxh.Name = "checkboxh";
            this.checkboxh.Size = new System.Drawing.Size(67, 20);
            this.checkboxh.TabIndex = 3;
            this.checkboxh.Text = "Hiking";
            this.checkboxh.UseVisualStyleBackColor = true;
            this.checkboxh.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // checkboxbox
            // 
            this.checkboxbox.AutoSize = true;
            this.checkboxbox.Location = new System.Drawing.Point(7, 86);
            this.checkboxbox.Name = "checkboxbox";
            this.checkboxbox.Size = new System.Drawing.Size(52, 20);
            this.checkboxbox.TabIndex = 2;
            this.checkboxbox.Text = "Box";
            this.checkboxbox.UseVisualStyleBackColor = true;
            this.checkboxbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // checkboxb
            // 
            this.checkboxb.AutoSize = true;
            this.checkboxb.Location = new System.Drawing.Point(7, 59);
            this.checkboxb.Name = "checkboxb";
            this.checkboxb.Size = new System.Drawing.Size(93, 20);
            this.checkboxb.TabIndex = 1;
            this.checkboxb.Text = "Basketball";
            this.checkboxb.UseVisualStyleBackColor = true;
            this.checkboxb.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // checkboxf
            // 
            this.checkboxf.AutoSize = true;
            this.checkboxf.Location = new System.Drawing.Point(7, 32);
            this.checkboxf.Name = "checkboxf";
            this.checkboxf.Size = new System.Drawing.Size(78, 20);
            this.checkboxf.TabIndex = 0;
            this.checkboxf.Text = "Football";
            this.checkboxf.UseVisualStyleBackColor = true;
            this.checkboxf.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnBirthDate);
            this.Controls.Add(this.lblbdate);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtemail1);
            this.Controls.Add(this.txtage1);
            this.Controls.Add(this.txtname1);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnAddListBox);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnincrease);
            this.Controls.Add(this.btndecrease);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cmbbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbox1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btndecrease;
        private System.Windows.Forms.Button btnincrease;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnAddListBox;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.TextBox txtname1;
        private System.Windows.Forms.TextBox txtage1;
        private System.Windows.Forms.TextBox txtemail1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblbdate;
        private System.Windows.Forms.Button btnBirthDate;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkboxh;
        private System.Windows.Forms.CheckBox checkboxbox;
        private System.Windows.Forms.CheckBox checkboxb;
        private System.Windows.Forms.CheckBox checkboxf;
    }
}

