using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            var bookmarks = BookmarkManager.GetItems();
            listBoxBookmarks.Items.Clear();
            foreach (var item in bookmarks)
            {
                listBoxBookmarks.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var bookmarks = BookmarkManager.GetItems();
            var filtered = bookmarks.FindAll(b => b.Title.ToLower().Contains(textBookmarkSearch.Text.ToLower()));
            listBoxBookmarks.Items.Clear();
            foreach (BookmarkItem item in filtered)
            {
                listBoxBookmarks.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BookmarkItem item = (BookmarkItem)listBoxBookmarks.SelectedItem;
            BookmarkManager.DeleteItem(item);
            load();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            BookmarkManager.DeleteAll();
            load();
        }
    }
}
