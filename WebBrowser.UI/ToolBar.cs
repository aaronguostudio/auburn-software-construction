using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class ToolBar : UserControl
    {
        Stack<string> backLinks = new Stack<string>();
        Stack<string> forwardLinks = new Stack<string>();

        string currentUrl = "";

        public ToolBar()
        {
            InitializeComponent();
            innerBrowser.ScriptErrorsSuppressed = true;
            updateUI();
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navigate(searchBox.Text);
            }
        }

        private void navigate(string url)
        {
            if (url == "")
            {
                return;
            }
            innerBrowser.Navigate(url);
            if (currentUrl != "")
            {
                backLinks.Push(currentUrl);
            }
            currentUrl = url;
            forwardLinks.Clear();
            updateUI();
        }

        private void back()
        {
            if (backLinks.Count > 0)
            {
                string url = backLinks.Pop();
                forwardLinks.Push(currentUrl);
                searchBox.Text = url;
                currentUrl = url;
                innerBrowser.Navigate(url);
                updateUI();
            }
        }

        private void forward()
        {
            if (forwardLinks.Count > 0)
            {
                string url = forwardLinks.Pop();
                backLinks.Push(currentUrl);
                searchBox.Text = url;
                currentUrl = url;
                innerBrowser.Navigate(url);
                updateUI();
            }
        }

        private void updateUI()
        {
            btnForward.Enabled = forwardLinks.Count > 0;
            btnBack.Enabled = backLinks.Count > 0;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            navigate(searchBox.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            back();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            forward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            innerBrowser.Navigate(currentUrl);
        }
    }
}
