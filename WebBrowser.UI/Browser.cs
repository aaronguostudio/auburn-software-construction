using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            innerBrowser.ScriptErrorsSuppressed = true;
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

        private void toolStripTextBox1_Enter(object sender, EventArgs e)
        {
            innerBrowser.Navigate("https://www.google.com");
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navigate();
            }
        }

        private void navigate()
        {
            if (searchBox.Text == "")
            {
                return;
            }
            innerBrowser.Navigate(searchBox.Text);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            navigate();
        }
    }
}
