namespace UserInterface.Controls.TimeLine
{
    public class TimeLineRow
    {
        public string Header { get; set; }
        public float Position { get; set; }
        public float Height { get; set; }

        public TimeLineRow(string header)
        {
            Header = header;
        }
    }
}