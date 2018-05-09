using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UserInterface.Controls
{
    public partial class EmailTextBox : TextBox
    {
        public ErrorProvider ErrorProvider { get; set; } = new ErrorProvider();

        public EmailTextBox()
        {
            InitializeComponent();
        }
        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
            if (Text.Length == 0)
            {
                e.Cancel = true;
                ErrorProvider.SetError(this, "Email is required");
            }
            else if (!Regex.IsMatch(Text, @"^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"))
            {
                e.Cancel = true;
                ErrorProvider.SetError(this, "Invalid Email");

            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(this, "");
            }
        }

    }
}
