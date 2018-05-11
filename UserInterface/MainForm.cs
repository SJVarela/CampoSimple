using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var reservasForm = ReservasForm.Instance();
            reservasForm.MdiParent = this;
            reservasForm.WindowState = FormWindowState.Maximized;
            reservasForm.Show();

        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var cuartosForm = CuartosForm.Instance();
            cuartosForm.MdiParent = this;
            cuartosForm.WindowState = FormWindowState.Maximized;
            cuartosForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
