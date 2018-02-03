using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controls
{
    class EmailTextBox : TextBox
    {
        private ErrorProvider errorProvider1;
        private System.ComponentModel.IContainer components;
        private TextBox textBox1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!IsValidEmail(textBox1.Text, out errorMsg))
            {
                e.Cancel = true;
                textBox1.Select(0, textBox1.Text.Length);
                this.errorProvider1.SetError(textBox1, errorMsg);
            }
        }
        private bool IsValidEmail(string email, out string errorMsg)
        {
            if (email.Length == 0)
            {
                errorMsg = "Email is required";
                return false;
            }
            if (!Regex.IsMatch(email, @"/w@/w./w"))
            {
                errorMsg = "Invalid Email";
                return false;
            }
            errorMsg = "";
            return true;
        }

        private void textBox1_Validated(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }
    }
}
