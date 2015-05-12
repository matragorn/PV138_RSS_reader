using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV138_RSS_Reader
{
    public partial class MainWindow : Form
    {
        private const int TREE_PANEL_MAX_WIDTH = 250;
        private const int TREE_PANEL_MIN_WIDTH = 150;
        private const int FEEDS_PANEL_MAX_WIDTH = 400;
        private const int FEEDS_PANEL_MIN_WIDTH = 150;
        private const int MAX_SHOWN_ARTICLES = 20; //TODO je to potreba? budeme listovat articles? nebo jich tam zobrazime milion... strasne dlouho se refresuje listview

        // TESTY
        private FeedManager manager;
        // /TESTY

        public MainWindow()
        {
            InitializeComponent();

            manager = new FeedManager(new DUMMYInMemoryStorage());
            //manager.SubscribeToURL("http://en.wikipedia.org/w/api.php?hidebots=1&days=7&limit=50&hidewikidata=1&action=feedrecentchanges&feedformat=atom");
            manager.SubscribeToURL("http://deoxy.org/koans?rss=1");
            //manager.SubscribeToURL("http://xkcd.com/rss.xml");
            //manager.SubscribeToURL("http://rss.sme.sk/rss/rss.asp?id=frontpage");
            manager.SubscribeToURL("http://idnes.cz.feedsportal.com/c/34387/f/625936/index.rss");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox dialog = new AboutBox();
            dialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer_Feeds_FeedDetails_MouseUp(object sender, MouseEventArgs e)
        {
            //odstrani nehezky vypadajici focus ze splitteru (bohuzel stale zustava po spusteni progrmau focus na vertikalnim splitteru)
            panel_FilterView.Focus(); 
        }

        private void splitContainer_Tree_MainContent_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainer_Tree_MainContent.SplitterDistance = Math.Max(splitContainer_Tree_MainContent.Panel1.Width, TREE_PANEL_MIN_WIDTH);
            splitContainer_Tree_MainContent.SplitterDistance = Math.Min(splitContainer_Tree_MainContent.Panel1.Width, TREE_PANEL_MAX_WIDTH);
        }

        private void splitContainer_Feeds_FeedDetails_SplitterMoved(object sender, SplitterEventArgs e)
        {

            splitContainer_FilterView_ArticleView.SplitterDistance = Math.Max(splitContainer_FilterView_ArticleView.Panel1.Height, FEEDS_PANEL_MIN_WIDTH);
            splitContainer_FilterView_ArticleView.SplitterDistance = Math.Min(splitContainer_FilterView_ArticleView.Panel1.Height, FEEDS_PANEL_MAX_WIDTH);
        }

        private void listView1_ItemSelectionChanged(object sender, System.Windows.Forms.ListViewItemSelectionChangedEventArgs e)
        {
            IArticle article = (IArticle)e.Item.Tag;
            if (e.Item.SubItems[0].Text == false.ToString())
            {
                manager.SetRead(article, true);
                e.Item.SubItems[0].Text = true.ToString();
            }

            webBrowser1.DocumentText = "<body style='font: 13px Microsoft Sans Serif, sans-serif'><h1>" + article.Title + "</h1>" + article.Description + "</body>";

        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            treeView_Filters.ExpandAll();
            
            RefreshView();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            manager.UpdateAllFeeds();
            RefreshView();
        }

        private void RefreshView()
        {
            listView1.SuspendLayout();
            listView1.Items.Clear();
            foreach (var article in manager.Articles(manager.Feeds.First()).Take(MAX_SHOWN_ARTICLES))
            {
                ListViewItem item = new ListViewItem(article.ToArray());
                item.Tag = article;
                listView1.Items.Add(item);
                listView1.Columns[3].Width = -1;
                listView1.Columns[4].Width = -2;
            }
            listView1.ResumeLayout();
        }



        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.ToString() != "about:blank")
            {
                System.Diagnostics.Process.Start(e.Url.ToString());
                e.Cancel = true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CategoryManager cm = new CategoryManager(manager);
            cm.ShowDialog();
        }
    }
}
