using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Data
{
    // class for managing bookmarkFolders
    class BookMarkFolder
    {
        // Name of the folder
        public string Name;

        // A list of the bookmarks in the folder
        public List<BookMark> BookMarks;

        public BookMarkFolder() { }
    }
}
