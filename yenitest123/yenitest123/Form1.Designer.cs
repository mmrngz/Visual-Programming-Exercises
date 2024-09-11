namespace yenitest123
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
            this.firstnamebox1 = new System.Windows.Forms.TextBox();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.lastnamebox1 = new System.Windows.Forms.TextBox();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstnamebox1
            // 
            this.firstnamebox1.Location = new System.Drawing.Point(412, 63);
            this.firstnamebox1.Name = "firstnamebox1";
            this.firstnamebox1.Size = new System.Drawing.Size(199, 22);
            this.firstnamebox1.TabIndex = 0;
            this.firstnamebox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Location = new System.Drawing.Point(328, 66);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(78, 16);
            this.firstnamelabel.TabIndex = 2;
            this.firstnamelabel.Text = "First Name: ";
            // 
            // lastnamebox1
            // 
            this.lastnamebox1.Location = new System.Drawing.Point(412, 92);
            this.lastnamebox1.Name = "lastnamebox1";
            this.lastnamebox1.Size = new System.Drawing.Size(199, 22);
            this.lastnamebox1.TabIndex = 3;
            this.lastnamebox1.TextChanged += new System.EventHandler(this.lastnamebox1_TextChanged);
            this.lastnamebox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastnamebox1_KeyPress);
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Location = new System.Drawing.Point(328, 98);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(78, 16);
            this.lastnamelabel.TabIndex = 4;
            this.lastnamelabel.Text = "Last Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 4, 0, 0);
            this.label1.Size = new System.Drawing.Size(112, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastnamelabel);
            this.Controls.Add(this.lastnamebox1);
            this.Controls.Add(this.firstnamelabel);
            this.Controls.Add(this.firstnamebox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnamebox1;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.TextBox lastnamebox1;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.Label label1;
    }
}

