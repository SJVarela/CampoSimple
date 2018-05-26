using System.Windows.Forms;

namespace UserInterface.Forms
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
    }
}
