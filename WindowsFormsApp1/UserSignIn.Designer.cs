namespace WindowsFormsApp1
{
    partial class UserSignIn
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
            this.nameTextBox1 = new WindowsFormsApp1.Controls.EmailTextBox();
            this.SuspendLayout();
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(12, 12);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox1.TabIndex = 0;
            this.nameTextBox1.TextChanged += new System.EventHandler(this.nameTextBox1_TextChanged);
            // 
            // UserSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.nameTextBox1);
            this.Name = "UserSignIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.EmailTextBox nameTextBox1;
    }
}

