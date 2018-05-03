using System;
using System.Drawing;

namespace UserInterface.Controls.TimeLine
{
    public class TimeLineBar
    {        
        public string Text { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Color Color { get; set; }
        public Color HoverColor { get; set; }
        public object DataSource { get; set; }
        public PointF Position { get; set; }

        public TimeLineBar(string text, DateTime startDate, DateTime endDate, Color color, Color hoverColor, PointF position, object dataSource = null)
        {
            Text = text;
            StartDate = startDate;
            EndDate = endDate;
            Color = color;
            HoverColor = hoverColor;
            Position = position;
            DataSource = dataSource;
        }
    }
}
