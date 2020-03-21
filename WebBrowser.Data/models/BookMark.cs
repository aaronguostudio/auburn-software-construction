using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Data
{
    // class for managing bookmarks
    class BookMark
    {
        // Title
        public string Title;

        // Url
        public string Url;

        // Description
        public string Description;

        public BookMark(string title, string url) { }

        public BookMark(string url) { }

        public BookMark() { }
    }
}
