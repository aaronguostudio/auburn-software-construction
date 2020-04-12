using System.Collections.Generic;
using WebBrowser.Data.BookmarkDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void Add(BookmarkItem bookmarkItem)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(bookmarkItem.URL, bookmarkItem.Title);
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
                item.Title = row.Title;
                item.URL = row.URL;
                results.Add(item);
            }

            return results;
        }

        public static void DeleteItem(BookmarkItem bookmarkItem)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Delete(bookmarkItem.Id, bookmarkItem.URL, bookmarkItem.Title);
        }

        public static void DeleteAll()
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();
            foreach(var row in rows)
            {
                adapter.Delete(row.Id, row.URL, row.Title);
            }
        }
    }
}