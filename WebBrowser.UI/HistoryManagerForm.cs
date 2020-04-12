using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManager_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            var items = HistoryManager.GetItems();
            listBoxHistories.Items.Clear();
            foreach (HistoryItem item in items)
            {
                listBoxHistories.Items.Add(item);
            }
        }

        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            var histories = HistoryManager.GetItems(); 
            var filtered = histories.Where(h => h.Title.ToLower().Contains(textSearchHistory.Text.ToLower()));
            listBoxHistories.Items.Clear();
            foreach(HistoryItem item in filtered)
            {
                listBoxHistories.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HistoryItem item = (HistoryItem) listBoxHistories.SelectedItem;
            HistoryManager.DeleteItem(item);
            load();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            HistoryManager.DeleteAll();
            load();
        }
    }
}
