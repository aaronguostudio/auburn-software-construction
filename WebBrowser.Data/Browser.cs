using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Data
{
    public class Browser
    {
        // browser version
        private string Version;

        // current active tab
        private Tab CurrentTab;

        // all opened tabs
        private List<Tab> Tabs;

        // all bookmarkfolders
        private List<BookMarkFolder> BookMarkFolders;

        // all browsing histories
        private List<History> Histories;
        
        public Browser(string url) { }

        public Browser() { }

        // bootstrap a new browser
        public void start() { }

        // minimize the browser

        // open a new tab
        public void openNewTab() { }

        // swtich to another tab
        public void switchTab() { }

        // close a tab
        public void closeTab() { }

        // open histories menu
        public void openHistories() { }

        // open bookmarks menu
        public void openBookMarks() { }

        // back to the privious item in the history
        public void back() { }

        // forward to the next item in the history
        public void forward() { }

        // stop the browser
        public void stop() { }

        // minimize the browser
        public void minimize() { }

        // maximize the browser
        public void maximize() { }

        // resize the browser
        public void resize() { }
    }
}
