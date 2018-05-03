using System;
using System.Collections.Generic;
using System.Drawing;

namespace UserInterface.Controls.TimeLine
{
    public class TimeLineGrid
    {
        public Pen LineStyle { get; set; } = Pens.DarkBlue;
        public List<TimeLineColumn> Columns { get; set; } = new List<TimeLineColumn>();
        public List<TimeLineRow> Rows { get; set; } = new List<TimeLineRow>();

        public TimeLineGrid(DateTime startDate, DateTime endDate)
        {
            Columns.Add(new TimeLineColumn("Rooms", null));

            for (int i = 0; i < (endDate - startDate).Days; i++)
            {
                Columns.Add(new TimeLineColumn(startDate.AddDays(i).ToString("dd/MM/yy"), startDate.AddDays(i)));
            }
        }
    }
}