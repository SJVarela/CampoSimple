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
        public int Index { get; set; }
    }
}
