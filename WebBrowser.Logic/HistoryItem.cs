using System;

namespace WebBrowser.Logic
{
    public class HistoryItem
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return string.Format("[{0}] {1} - ({2})", Date, Title, URL);
        }
    }
}
