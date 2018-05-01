using System.Windows.Forms;

namespace UserInterface.Controls
{
    public partial class PasswordTextBox : TextBox
    {
        private ErrorProvider errorProvider;
        public PasswordTextBox(ErrorProvider errorProvider)
        {
            InitializeComponent();
            this.errorProvider = errorProvider;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
