using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace UserInterface.Controls.Scheduler
{
    public partial class Scheduler : DataGridView
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public BindingList<Reserva> Reservas { get; set; } = new BindingList<Reserva>();

        public Scheduler()
        {
            InitializeComponent();
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Reservas.Add(new Reserva() { StartDate = DateTime.Today, Room = 1, EndDate = new DateTime(2018, 5, 3) });
            this.Reservas.Add(new Reserva() { StartDate = new DateTime(2018, 5, 10), Room = 2, EndDate = new DateTime(2018, 5, 12) });

            int daysSpan = (EndDate - StartDate).Days;
            this.Columns.Add("Room", "Room");
            for (int i = 0; i <= daysSpan; i++)
            {
                this.Columns.Add(i.ToString(), new DateTime(StartDate.Ticks).AddDays(i).Date.ToString());
            }
            foreach(Reserva reserva in Reservas)
            {
                var newRow = this.Rows.Add();
                this.Rows[newRow].Cells[0].Value = reserva.Room;
                for(int i = 1; i <= daysSpan; i++)
                {
                    if(DateTime.Parse(this.Columns[i].HeaderText) >= reserva.StartDate && DateTime.Parse(this.Columns[i].HeaderText) <= reserva.EndDate)
                    {
                        this.Rows[newRow].Cells[i].Style.BackColor = Color.Red;
                    }
                }
            }
        }

    }
}
