namespace Week10LabMine
{
    partial class RecordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrecordid = new System.Windows.Forms.TextBox();
            this.txtrecordbookname = new System.Windows.Forms.TextBox();
            this.txtrecordauthor = new System.Windows.Forms.TextBox();
            this.txtrecordpagecount = new System.Windows.Forms.TextBox();
            this.btnrecordaddbook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İD: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Page Count :";
            // 
            // txtrecordid
            // 
            this.txtrecordid.Location = new System.Drawing.Point(131, 27);
            this.txtrecordid.Name = "txtrecordid";
            this.txtrecordid.Size = new System.Drawing.Size(100, 22);
            this.txtrecordid.TabIndex = 4;
            // 
            // txtrecordbookname
            // 
            this.txtrecordbookname.Location = new System.Drawing.Point(131, 67);
            this.txtrecordbookname.Name = "txtrecordbookname";
            this.txtrecordbookname.Size = new System.Drawing.Size(100, 22);
            this.txtrecordbookname.TabIndex = 5;
            // 
            // txtrecordauthor
            // 
            this.txtrecordauthor.Location = new System.Drawing.Point(131, 110);
            this.txtrecordauthor.Name = "txtrecordauthor";
            this.txtrecordauthor.Size = new System.Drawing.Size(100, 22);
            this.txtrecordauthor.TabIndex = 6;
            // 
            // txtrecordpagecount
            // 
            this.txtrecordpagecount.Location = new System.Drawing.Point(131, 147);
            this.txtrecordpagecount.Name = "txtrecordpagecount";
            this.txtrecordpagecount.Size = new System.Drawing.Size(100, 22);
            this.txtrecordpagecount.TabIndex = 7;
            // 
            // btnrecordaddbook
            // 
            this.btnrecordaddbook.Location = new System.Drawing.Point(27, 192);
            this.btnrecordaddbook.Name = "btnrecordaddbook";
            this.btnrecordaddbook.Size = new System.Drawing.Size(204, 51);
            this.btnrecordaddbook.TabIndex = 8;
            this.btnrecordaddbook.Text = "Add Book";
            this.btnrecordaddbook.UseVisualStyleBackColor = true;
            this.btnrecordaddbook.Click += new System.EventHandler(this.btnrecordaddbook_Click);
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 265);
            this.Controls.Add(this.btnrecordaddbook);
            this.Controls.Add(this.txtrecordpagecount);
            this.Controls.Add(this.txtrecordauthor);
            this.Controls.Add(this.txtrecordbookname);
            this.Controls.Add(this.txtrecordid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecordForm";
            this.Text = "RecordForm";
            this.Load += new System.EventHandler(this.RecordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrecordid;
        private System.Windows.Forms.TextBox txtrecordbookname;
        private System.Windows.Forms.TextBox txtrecordauthor;
        private System.Windows.Forms.TextBox txtrecordpagecount;
        private System.Windows.Forms.Button btnrecordaddbook;
    }
}