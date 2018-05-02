using System;
using System.Windows.Forms;
using UserInterface.Controls.Scheduler;

namespace UserInterface
{
    public partial class ReservasForm : Form
    {
        private Scheduler calendar;
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
            calendar = new Scheduler() { StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(20) };
            calendar.Dock = DockStyle.Fill;
            this.Controls.Add(calendar);
        }
    }
}
