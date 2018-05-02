using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UserInterface.Controls.TimeLine
{
    public partial class TimeLine : UserControl
    {
        private Bitmap bmp;
        private Graphics graphics;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public TimeLineHeader Header { get; set; }
        public List<TimeLineBar> Bars = new List<TimeLineBar>();

        private int chartSpan;
        private int gridWidth;
        private int headerHeight;

        public TimeLine(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            bmp = new Bitmap(1280, 1024);
            graphics = Graphics.FromImage(bmp);
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            StartDate = startDate;
            EndDate = endDate;

        }

        public void AddBar(TimeLineBar bar)
        {
            TimeSpan span = bar.StartDate - bar.EndDate;
            Bars.Add(bar);
        }

        private void PaintChart(Graphics gfx)
        {
            chartSpan = (EndDate - StartDate).Days;
            gridWidth = Width / chartSpan;
            DrawHeader(gfx);
            DrawBars(gfx);
            DrawVerticalGrid(gfx);
        }
        private void DrawBars(Graphics gfx)
        {
            foreach (TimeLineBar bar in Bars)
            {
                int startLocation = (bar.StartDate - StartDate).Days * gridWidth;
                int width = (bar.EndDate - bar.StartDate).Days * gridWidth;
                Rectangle barRectangle = new Rectangle(startLocation, headerHeight, width, 10);
                gfx.DrawRectangle(Pens.Black, barRectangle);
            }
        }

        private void DrawHeader(Graphics gfx)
        {
            for (int i = 0; i <= chartSpan; i++)
            {
                gfx.DrawString(StartDate.AddDays(i).ToString("d-MMM"), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, (i * gridWidth)+gridWidth/2, 0);
            }
            headerHeight = 8;
        }

        private void DrawVerticalGrid(Graphics gfx)
        {
            for(int i = 0; i < chartSpan; i++)
            {
                gfx.DrawLine(Pens.Bisque, i * gridWidth, 0, i * gridWidth, Height);
            }

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PaintChart(e.Graphics);
        }
    }
}
