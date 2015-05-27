using PV138_RSS_Reader.Storage;
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

        private TreeNode unreadFeeds;
        private TreeNode categories;
        private TreeNode allFeeds;
        private TreeNode starredFeeds;

        private IEnumerable<IArticle> actualyShowingArticles = new List<IArticle>();

        private const int TIME_TO_READ = 1;
        /// <summary>
        /// clanek se oznaci za precteny pokud bude zobrazen alespon TIME_TO_READ sekund 
        /// TODO: umožnit nastavení této konstanty uživatelovi? a ukladat do XML?
        /// </summary>
        Timer readTimer = new Timer();


        // TESTY
        private FeedManager manager;
        // /TESTY

        public MainWindow()
        {
            InitializeComponent();

            readTimer.Tick += readTimer_Tick;
            readTimer.Interval = 1000 * TIME_TO_READ;
            unreadFeeds = treeView_Filters.Nodes[0];
            categories = treeView_Filters.Nodes[1];
            allFeeds = treeView_Filters.Nodes[2];
            starredFeeds = treeView_Filters.Nodes[3];

            manager = new FeedManager(new XMLStorage("FeedRead.dat"));

            if (manager.Feeds.Count == 0)
            {
                //manager.SubscribeToURL("http://en.wikipedia.org/w/api.php?hidebots=1&days=7&limit=50&hidewikidata=1&action=feedrecentchanges&feedformat=atom");
                manager.SubscribeToURL("http://deoxy.org/koans?rss=1");
                //manager.SubscribeToURL("http://xkcd.com/rss.xml");
                //manager.SubscribeToURL("http://rss.sme.sk/rss/rss.asp?id=frontpage");
                //manager.SubscribeToURL("http://idnes.cz.feedsportal.com/c/34387/f/625936/index.rss");
            }
            manager.UpdateAllFeeds();

            UpdateTreeView();

            ListViewImageInit();
        }

        private void ListViewImageInit()
        {
            listView1.SmallImageList = new ImageList();
            listView1.SmallImageList.Images.Add(Properties.Resources.noStar);
            listView1.SmallImageList.Images.Add(Properties.Resources.Star);

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
            readTimer.Stop();
            readTimer.Interval = 1000 * TIME_TO_READ;
            IArticle article = (IArticle)e.Item.Tag;
            if (!article.Read) { readTimer.Start(); }

            webBrowser1.DocumentText = "<body style='font: 13px Microsoft Sans Serif, sans-serif'><h1>" + article.Title + "</h1>" + article.Description + "</body>";

        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            treeView_Filters.ExpandAll();
            actualyShowingArticles = manager.Articles(manager.Feeds.First()).Take(MAX_SHOWN_ARTICLES);
            RefreshView();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            manager.UpdateAllFeeds();
            RefreshView();
            UpdateTreeView();
        }

        private void RefreshView()
        {
            listView1.SuspendLayout();
            listView1.BeginUpdate();
            listView1.Visible = false;
            listView1.Items.Clear();

            foreach (var article in actualyShowingArticles)
            {
                ListViewItem item = new ListViewItem(article.ToArray());
                item.ImageIndex = article.Starred ? 1 : 0;
                item.Font = new System.Drawing.Font(item.Font, article.Read ? FontStyle.Regular : FontStyle.Bold);
                item.Tag = article;
                listView1.Items.Add(item);
                listView1.Columns[0].Width = -1;
                listView1.Columns[0].Width += 10;
                listView1.Columns[1].Width = -1;
                listView1.Columns[1].Width += 10;
                listView1.Columns[2].Width = -2;
            }

            listView1.Visible = true;
            listView1.EndUpdate();
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
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {

            //DEBUG
            List<IFeed> unread = manager.getUnreadFeeds();
            List<IFeed> starred = manager.getStarredFeeds();
            //END_DEBUG
            var selectedNode = treeView_Filters.SelectedNode;

            unreadFeeds.Nodes.Clear();
            unreadFeeds.Nodes.AddRange(NodesFromFeeds(manager.getUnreadFeeds()));

            allFeeds.Nodes.Clear();
            allFeeds.Nodes.AddRange(NodesFromFeeds(manager.Feeds));

            starredFeeds.Nodes.Clear();
            starredFeeds.Nodes.AddRange(NodesFromFeeds(manager.getStarredFeeds()));

            categories.Nodes.Clear();
            categories.Nodes.AddRange(CategoryNodes(manager.Storage.GetCategories()));
            
            treeView_Filters.SelectedNode = selectedNode;

        }

        private TreeNode[] CategoryNodes(List<Category> categories)
        {
            TreeNode[] nodes = new TreeNode[categories.Count];

            for (int i = 0; i < categories.Count; i++)
            {
                TreeNode node = new TreeNode(categories[i].ToString());
                node.Nodes.Clear();
                node.Nodes.AddRange(NodesFromFeeds(categories[i].Feeds));
                nodes[i] = node;
            }
            return nodes;
        }

        private TreeNode[] NodesFromFeeds(List<IFeed> unread)
        {
            TreeNode[] nodes = new TreeNode[unread.Count];
            int index = 0;
            foreach (Feed item in unread)
            {
                TreeNode node = new TreeNode(item.ToString());
                node.Tag = item;
                nodes[index] = node;
                index++;
            }
            if (nodes.Length < 1)
            {
                return new TreeNode[] { new TreeNode() { Text = "ŽÁDNÉ FEEDY", Tag = null } };
            }
            return nodes;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {


            if (listView1.SelectedItems.Count < 1)
            {
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];
            var index = listView1.SelectedIndices[0];


            int xMin = item.Position.X; ;
            int xMax = xMin + 15;
            if (e.X >= xMin && e.X <= xMax)
            {
                manager.SetStarred(((IArticle)item.Tag), !((IArticle)item.Tag).Starred);
                //RefreshView();
                item.ImageIndex = ((IArticle)item.Tag).Starred ? 1 : 0;

                listView1.Items[index].Selected = true;
                UpdateTreeView();
            }
        }

        void readTimer_Tick(object sender, EventArgs e)
        {

            readTimer.Stop();
            readTimer.Interval = 1000 * TIME_TO_READ;
            if (listView1.SelectedItems.Count < 1)
            {
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];
            if (((IArticle)item.Tag).Read) { return; }
            var index = listView1.SelectedIndices[0];

            manager.SetRead((IArticle)item.Tag, true);

            //RefreshView();
            item.Font = new System.Drawing.Font(item.Font, FontStyle.Regular);

            if (listView1.Items.Count > index)
            {
                listView1.Items[index].Selected = true;
            }
            UpdateTreeView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// po kliknuti a vybrani kategorie feedu ci articku z leveho menu nastavi kolekci zbrazovanyh clanku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_Filters_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == unreadFeeds)
            {
                actualyShowingArticles = (manager.Articles((Feed)e.Node.Tag)).Where(x => !x.Read).ToList();
            }
            else if (e.Node.Parent == categories)
            {
                var list = new List<IArticle>();
                foreach (TreeNode node in e.Node.Nodes)
                {
                    if (node.Tag is IFeed)
                    {
                        list.AddRange((manager.Articles((Feed)node.Tag)));
                    }
                }
                actualyShowingArticles = list;
            }
            else if (e.Node.Parent != null && e.Node.Parent.Parent == categories)
            {
                var list = new List<IArticle>();
                list.AddRange((manager.Articles((Feed)e.Node.Tag)));
                actualyShowingArticles = list;
            }
            else if (e.Node.Parent == allFeeds)
            {
                actualyShowingArticles = manager.Articles((Feed)e.Node.Tag).ToList();
            }
            else if (e.Node.Parent == starredFeeds)
            {
                actualyShowingArticles = (manager.Articles((Feed)e.Node.Tag)).Where(x => x.Starred).ToList();
            }

            else if (e.Node == starredFeeds)
            {
                var list = new List<IArticle>();
                foreach (TreeNode node in e.Node.Nodes)
                {
                    list.AddRange((manager.Articles((Feed)node.Tag)).Where(x => x.Starred));
                }
                actualyShowingArticles = list;
            }
            else if (e.Node == unreadFeeds)
            {
                var list = new List<IArticle>();
                foreach (TreeNode node in e.Node.Nodes)
                {
                    list.AddRange((manager.Articles((Feed)node.Tag)).Where(x => !x.Read));
                }
                actualyShowingArticles = list;
            }
            else if (e.Node == allFeeds)
            {
                var list = new List<IArticle>();
                foreach (TreeNode node in e.Node.Nodes)
                {
                    list.AddRange((manager.Articles((Feed)node.Tag)));
                }
                actualyShowingArticles = list;
            }
            else if (e.Node == categories)
            {
                 
                var set = new HashSet<IArticle>();
                foreach (TreeNode nodes in e.Node.Nodes)
                {
                    foreach (TreeNode node in nodes.Nodes)
                    {
                        if (node.Tag is IFeed)
                        {
                            foreach (var item in ((manager.Articles((Feed)node.Tag))))
                            {
                                set.Add(item);
                            }
                        }
                    }
                }
                actualyShowingArticles = set;
            }
            RefreshView();
        }
    }
}
