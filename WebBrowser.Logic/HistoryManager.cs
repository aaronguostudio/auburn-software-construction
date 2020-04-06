using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddItem(HistoryItem historyItem)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(historyItem.Title, historyItem.URL, historyItem.Date);
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
    }
}
