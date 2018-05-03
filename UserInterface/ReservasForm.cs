using Braincase.GanttChart;
using System;
using System.Drawing;
using System.Windows.Forms;
using UserInterface.Controls.TimeLine;

namespace UserInterface
{
    public partial class ReservasForm : Form
    {
        private ProjectManager manager;
        protected ReservasForm()
        {
            InitializeComponent();
            manager = new ProjectManager();
            manager.Start = DateTime.Today;
            var task = new Task() { Name = "name1" };
            manager.Add(task);
            manager.SetStart(task, TimeSpan.FromDays(4));
            manager.SetDuration(task, TimeSpan.FromDays(6));

            Schedualer.Init(manager);
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
