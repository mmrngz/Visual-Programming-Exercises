namespace LabQuestion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtDimension = new TextBox();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 34);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Dimension : ";
            // 
            // txtDimension
            // 
            txtDimension.Location = new Point(117, 31);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(100, 23);
            txtDimension.TabIndex = 1;
            txtDimension.TextChanged += txtDimension_TextChanged;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblError.ForeColor = Color.FromArgb(192, 0, 0);
            lblError.Location = new Point(40, 84);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 30);
            lblError.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 349);
            Controls.Add(lblError);
            Controls.Add(txtDimension);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDimension;
        private Label lblError;
    }
}