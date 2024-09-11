namespace TekrarVisualProgramming
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
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.BtnAdd1 = new System.Windows.Forms.Button();
            this.cmbbox1 = new System.Windows.Forms.ComboBox();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(35, 12);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(121, 22);
            this.txtBox1.TabIndex = 0;
            // 
            // BtnAdd1
            // 
            this.BtnAdd1.Location = new System.Drawing.Point(162, 12);
            this.BtnAdd1.Name = "BtnAdd1";
            this.BtnAdd1.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd1.TabIndex = 1;
            this.BtnAdd1.Text = "Add";
            this.BtnAdd1.UseVisualStyleBackColor = true;
            this.BtnAdd1.Click += new System.EventHandler(this.BtnAdd1_Click);
            // 
            // cmbbox1
            // 
            this.cmbbox1.FormattingEnabled = true;
            this.cmbbox1.Location = new System.Drawing.Point(35, 49);
            this.cmbbox1.Name = "cmbbox1";
            this.cmbbox1.Size = new System.Drawing.Size(127, 24);
            this.cmbbox1.TabIndex = 2;
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(168, 50);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(75, 23);
            this.btnDelete1.TabIndex = 3;
            this.btnDelete1.Text = "Delete";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 613);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.cmbbox1);
            this.Controls.Add(this.BtnAdd1);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button BtnAdd1;
        private System.Windows.Forms.ComboBox cmbbox1;
        private System.Windows.Forms.Button btnDelete1;
    }
}

