using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UserInterface.Controls
{
    public partial class EmailTextBox : TextBox
    {
        private ErrorProvider errorProvider;
        public EmailTextBox(ErrorProvider error)
        {
            InitializeComponent();
            errorProvider = error;
        }
        private bool IsValidEmail(string email, out string errorMsg)
        {
            if (email.Length == 0)
            {
                errorMsg = "Email is required";
                return false;
            }

            if (!Regex.IsMatch(email, @"^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"))
            {
                errorMsg = "Invalid Email";
                return false;
            }
            errorMsg = "";
            return true;
        }
        protected override void OnLostFocus(EventArgs e)
        {
            string errorMsg;
            if (!IsValidEmail(this.Text, out errorMsg))
            {
                errorProvider.SetError(this, errorMsg);
            }
            else
            {
                errorProvider.SetError(this, "");
            }
            base.OnLostFocus(e);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
