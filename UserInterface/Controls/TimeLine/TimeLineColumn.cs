using System;

namespace UserInterface.Controls.TimeLine
{
    public class TimeLineColumn
    {
        public string Header { get; set; }
        public float Position { get; set; }
        public float Width { get; set; }
        public DateTime? Date { get; set; }

        public TimeLineColumn(string header, DateTime? date)
        {
            Header = header;
            Date = date;
        }
    }
}