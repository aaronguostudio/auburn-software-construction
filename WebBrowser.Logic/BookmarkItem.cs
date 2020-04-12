namespace WebBrowser.Logic
{
    public class BookmarkItem
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - ({1})", Title, URL);
        }
    }
}
