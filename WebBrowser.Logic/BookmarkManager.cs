using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarkDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void Add(BookmarkItem bookmarkItem)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(bookmarkItem.Title, bookmarkItem.URL);
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();
            
            foreach(var row in rows)
            {
                var item = new BookmarkItem();
                item.Id = row.Id;
                item.Title = item.Title;
                item.URL = item.URL;
                results.Add(item);
            }

            return results;
        }
    }
}