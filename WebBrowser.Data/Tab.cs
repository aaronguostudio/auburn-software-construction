using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Data
{
    class Tab
    {
        private const string DEFAULT_TAB_NAME = "New Tab";

        // Title of the tab
        public string Title { get; set; }

        // Favicon
        public string Favicon { get; set; }

        // Url
        public string Url { get; set; }

        // If the tab is active
        public bool IsActive { get; set; }

        // If the tab is on dray
        public bool IsOnDrag { get; set; }
        
        public Tab(string name, string url) { }

        public Tab(string url) { }

        public Tab() { }

        // open the tab
        public void open() { }

        // close the tab
        public void close() { }

        // refresh the tab
        public void refresh() { }
    }
}
