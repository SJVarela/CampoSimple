using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UserInterface.Controls.TimeLine
{
    public partial class TimeLine : UserControl
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public TimeLineGrid Grid { get; set; }
        public List<TimeLineBar> Bars = new List<TimeLineBar>();


        public TimeLine(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            StartDate = startDate;
            EndDate = endDate;

            Grid = new TimeLineGrid(StartDate, EndDate);
            Grid.Rows.Add(new TimeLineRow("Room 1"));
            Grid.Rows.Add(new TimeLineRow("Room 1"));
            Grid.Rows.Add(new TimeLineRow("Room 1"));
            Grid.Rows.Add(new TimeLineRow("Room 1"));
        }

        public void AddBar(TimeLineBar bar)
        {
            Bars.Add(bar);
        }

        private void PaintChart(Graphics gfx)
        {
            DrawGrid(gfx);
        }
        private void DrawBars(Graphics gfx)
        {
        }

        private void DrawGrid(Graphics gfx)
        {
            int i = 0;
            SizeF headerSize = gfx.MeasureString("dd/MM/yy", Font); //TODO: Mejorar
            foreach (TimeLineColumn column in Grid.Columns)
            {
                column.Position = headerSize.Width * i;
                gfx.DrawString(column.Header, Font, Brushes.Black, column.Position, 0);
                gfx.DrawLine(Grid.LineStyle, column.Position, 0, column.Position, Height);
                i++;
            }
            i = 0;
            foreach (TimeLineRow row in Grid.Rows)
            {
                row.Height = headerSize.Height;
                row.Position = headerSize.Height + row.Height * i;
                gfx.DrawString(row.Header, Font, Brushes.Black, 0, row.Position);
                gfx.DrawLine(Grid.LineStyle, 0, row.Position, Width, row.Position);
                i++;
            }

        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PaintChart(e.Graphics);
        }

    }
}
