namespace UserInterface
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailTextbox1 = new UserInterface.Controls.EmailTextbox();
            this.emailTextBox11 = new UserInterface.Controls.EmailTextBox1(errorProvider1);

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // emailTextBox11
            // 
            this.emailTextBox11.Location = new System.Drawing.Point(13, 40);
            this.emailTextBox11.Name = "emailTextBox11";
            this.emailTextBox11.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox11.TabIndex = 1;
            // 
            // emailTextbox1
            // 
            this.emailTextbox1.Location = new System.Drawing.Point(13, 13);
            this.emailTextbox1.Name = "emailTextbox1";
            this.emailTextbox1.Size = new System.Drawing.Size(100, 20);
            this.emailTextbox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.emailTextBox11);
            this.Controls.Add(this.emailTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.EmailTextbox emailTextbox1;
        private Controls.EmailTextBox1 emailTextBox11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

