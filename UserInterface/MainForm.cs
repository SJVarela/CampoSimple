using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var reservasForm = ReservasForm.Instance();
            reservasForm.MdiParent = this;
            reservasForm.WindowState = FormWindowState.Maximized;
            reservasForm.Show();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var cuartosForm = CuartosForm.Instance();
            cuartosForm.MdiParent = this;
            cuartosForm.WindowState = FormWindowState.Maximized;
            cuartosForm.MinimizeBox = false;
            cuartosForm.Show();
        }
    }
}
