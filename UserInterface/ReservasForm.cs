using System.Windows.Forms;

namespace UserInterface
{
    public partial class ReservasForm : Form
    {

        protected ReservasForm()
        {
            InitializeComponent();
        }
        private static ReservasForm form;
        public static ReservasForm Instance()
        {
            if (form == null)
            {
                form = new ReservasForm();
            }
            return form;
        }

        private void ReservasForm_Load(object sender, System.EventArgs e)
        {
        }
    }
}
