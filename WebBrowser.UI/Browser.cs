﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "A Plus Browser is a light weight browser offers very simple browsing functionalies. Current verson 1.0";
            string caption = "A Plus Browser";
            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }

        private void Browser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.T)
            {
                newTab();
            }

            if(e.Control && e.KeyCode == Keys.W)
            {
                closeTab();
            }
        }

        private void newTab()
        {
            UserControl toolBar = new ToolBar();
            toolBar.Dock = DockStyle.Fill;
            TabPage newTabPage = new TabPage("New Tab");
            newTabPage.Controls.Add(toolBar);
            tabControl.TabPages.Add(newTabPage);
        }

        private void closeTab()
        {
            tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTab();
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeTab();
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyManagerForm = new HistoryManagerForm();
            historyManagerForm.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkManagerForm bookmarkManagerForm = new BookmarkManagerForm();
            bookmarkManagerForm.ShowDialog();
        }

        private void Browser_Load(object sender, EventArgs e)
        {

        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.DeleteAll();
        }
    }
}
