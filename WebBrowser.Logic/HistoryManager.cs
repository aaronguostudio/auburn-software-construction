using System.Collections.Generic;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddItem(HistoryItem historyItem)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(historyItem.URL, historyItem.Title, historyItem.Date);
        }

        public static List<HistoryItem> GetItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach(var row in rows)
            {
                var item = new HistoryItem();
                item.Id = row.Id;
                item.Title = row.Title;
                item.URL = row.URL;
                item.Date = row.Date;
                results.Add(item);
            }

            return results;
        }

        public static void DeleteItem(HistoryItem historyItem)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Delete(historyItem.Id, historyItem.URL, historyItem.Title, historyItem.Date);
        }

        public static void DeleteAll()
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                adapter.Delete(row.Id, row.URL, row.Title, row.Date);
            }
        }
    }
}
