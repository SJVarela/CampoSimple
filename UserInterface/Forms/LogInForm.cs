using System;
using System.Windows.Forms;

namespace UserInterface.Forms
{
    public partial class LogInForm : Form
    {

        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("Test");
            }
        }
    }
}
