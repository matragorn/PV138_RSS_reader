using PV138_RSS_Reader.Exceptions;
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
        private const int TREE_PANEL_MAX_WIDTH = 1000;
        private const int TREE_PANEL_MIN_WIDTH = 150;
        private const int FEEDS_PANEL_MAX_WIDTH = 1000;
        private const int FEEDS_PANEL_MIN_WIDTH = 150;
        private const int MAX_SHOWN_ARTICLES = 20; //TODO je to potreba? budeme listovat articles? nebo jich tam zobrazime milion... strasne dlouho se refresuje listview

        private TreeNode unreadFeeds;
        private TreeNode categories;
        private TreeNode allFeeds;
        private TreeNode starredFeeds;

        private IEnumerable<IArticle> actuallyShowingArticles = new List<IArticle>();

        private const float TIME_TO_READ = 0.001f;
        private const int SEARCH_INTERVAL = 500; //ms
        /// <summary>
        /// clanek se oznaci za precteny pokud bude zobrazen alespon TIME_TO_READ sekund 
        /// TODO: umožnit nastavení této konstanty uživatelovi? a ukladat do XML?
        /// </summary>
        Timer readTimer = new Timer();
        Timer searchTimer = new Timer();
        private bool _canSearch = false;

        // TESTY
        private FeedManager manager;
        // /TESTY

        public MainWindow()
        {
            InitializeComponent();

            readTimer.Tick += readTimer_Tick;
            readTimer.Interval = (int)(1000 * TIME_TO_READ+1);
            searchTimer.Interval = SEARCH_INTERVAL;
            searchTimer.Tick += searchTimer_Tick;

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

        void searchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Interval = SEARCH_INTERVAL;
            search();
        }

        private void ListViewImageInit()
        {
            listView1.SmallImageList = new ImageList();
            listView1.SmallImageList.Images.Add(Properties.Resources.noStar);
            listView1.SmallImageList.Images.Add(Properties.Resources.Star);

        }

        /// <summary>
        /// zobrazí about box
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event argument</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox dialog = new AboutBox();
            dialog.ShowDialog();
        }

        /// <summary>
        /// ukončí aplikaci
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event argument</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// odstrani nehezky vypadajici focus ze splitteru (bohuzel stale zustava po spusteni progrmau focus na vertikalnim splitteru)
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arg</param>
        private void splitContainer_Feeds_FeedDetails_MouseUp(object sender, MouseEventArgs e)
        {
            //odstrani nehezky vypadajici focus ze splitteru (bohuzel stale zustava po spusteni progrmau focus na vertikalnim splitteru)
            panel_FilterView.Focus();
        }

        /// <summary>
        /// blokuje nastavení šírky treewiev nad hodnotu maximalna
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arg</param>
        private void splitContainer_Tree_MainContent_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainer_Tree_MainContent.SplitterDistance = Math.Max(splitContainer_Tree_MainContent.Panel1.Width, TREE_PANEL_MIN_WIDTH);
            splitContainer_Tree_MainContent.SplitterDistance = Math.Min(splitContainer_Tree_MainContent.Panel1.Width, TREE_PANEL_MAX_WIDTH);
        }

        /// <summary>
        /// blokuje nastavení výsky seznamu clanku nad hodnotu maximalna
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arg</param>
        private void splitContainer_Feeds_FeedDetails_SplitterMoved(object sender, SplitterEventArgs e)
        {

            splitContainer_FilterView_ArticleView.SplitterDistance = Math.Max(splitContainer_FilterView_ArticleView.Panel1.Height, FEEDS_PANEL_MIN_WIDTH);
            splitContainer_FilterView_ArticleView.SplitterDistance = Math.Min(splitContainer_FilterView_ArticleView.Panel1.Height, FEEDS_PANEL_MAX_WIDTH);
        }

        /// <summary>
        /// pri zmeně vybraného článku zobrazí vybraný článek v dolním okně
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arg</param>
        private void listView1_ItemSelectionChanged(object sender, System.Windows.Forms.ListViewItemSelectionChangedEventArgs e)
        {
            readTimer.Stop();
            readTimer.Interval = (int)(1000 * TIME_TO_READ);
            IArticle article = (IArticle)e.Item.Tag;
            if (!article.Read) { readTimer.Start(); }

             webBrowser1.DocumentText = "<html><head><style>"+Properties.Resources.ARTICLE_CSS+"</style></head><body>" +

                    "<a href='"+article.URL+"'><h1>" + article.Title + "</h1></a>" +

                    article.Description +

                "</body></html>";

        }
        /// <summary>
        /// handle on load, potrebne rutiny po zapnuti
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arg</param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            treeView_Filters.ExpandAll();
            actuallyShowingArticles = manager.Articles(manager.Feeds.First()).Take(MAX_SHOWN_ARTICLES);
            RefreshView();
        }


        /// <summary>
        /// handle refresh buttonu, aktualizuje feedy a updatne GUI
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arg</param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            manager.UpdateAllFeeds();
            RefreshView();
            UpdateTreeView();
        }

        /// <summary>
        /// refreshne seznam clanku, podle obsahu kolekce s aktualne zobrazovanymi clanky
        /// </summary>
        private void RefreshView()
        {
            listView1.SuspendLayout();
            listView1.BeginUpdate();
            listView1.Visible = false;
            listView1.Items.Clear();

            foreach (var article in actuallyShowingArticles)
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

        /// <summary>
        /// handler řešící webové odkazy
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arg</param>
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.ToString() != "about:blank")
            {
                System.Diagnostics.Process.Start(e.Url.ToString());
                e.Cancel = true;
            }
        }


        /// <summary>
        /// andler vyvolany po stisknuti tlacitka sprava kategorii, otevře uzivateli dialog se spravou catgorii
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arg</param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CategoryManager cm = new CategoryManager(manager);
            cm.ShowDialog();
            UpdateTreeView();

        }


        /// <summary>
        /// updatuje Treeview
        /// </summary>
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

        /// <summary>
        /// vytvoří treenode do stromu s feedy ze zadaneho listu categorií
        /// </summary>
        /// <param name="categories">list categorii</param>
        /// <returns>pole treenodes</returns>
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

        /// <summary>
        /// vytvoří pole  treenode  do stromu s feedy ze zadaneho listu feedu
        /// </summary>
        /// <param name="categories">list feedu</param>
        /// <returns>pole treenodes</returns>
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


        /// <summary>
        /// handle obsluha kliku na seznam clanku, pri kliku na hvezdicku, pridani do oblibenych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (((IArticle)item.Tag).Identificator == "Nenalezeny žádné feedy")
                {
                    return;
                }
                manager.SetStarred(((IArticle)item.Tag), !((IArticle)item.Tag).Starred);
                ((IArticle)item.Tag).Starred = !((IArticle)item.Tag).Starred;
                item.ImageIndex = ((IArticle)item.Tag).Starred ? 1 : 0;
                Application.DoEvents();
                //listView1.Items[index].Selected = true;
                UpdateTreeView();
            }
        }


        /// <summary>
        /// udalost po vyprseni timeru delaye pro zaznacny přečtení článku  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void readTimer_Tick(object sender, EventArgs e)
        {

            readTimer.Stop();
            readTimer.Interval = (int)(1000 * TIME_TO_READ);
            if (listView1.SelectedItems.Count < 1)
            {
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];
            if (((IArticle)item.Tag).Read) { return; }
            if (((IArticle)item.Tag).Identificator == "Nenalezeny žádné feedy")
            {
                return;
            }
            var index = listView1.SelectedIndices[0];

            try
            {
                manager.SetRead((IArticle)item.Tag, true);
            }
            catch
            {
                int breakPoint  = 0;
            }
            //RefreshView();
            item.Font = new System.Drawing.Font(item.Font, FontStyle.Regular);

            if (listView1.Items.Count > index)
            {
                listView1.Items[index].Selected = true;
            }
            UpdateTreeView();
        }

        /// <summary>
        /// po kliknuti a vybrani kategorie feedu ci articku z leveho menu nastavi kolekci zbrazovanyh clanku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_Filters_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Parent == categories)
                {
                    var list = new List<IArticle>();
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        if (node.Tag is IFeed)
                        {
                            list.AddRange((manager.Articles((Feed)node.Tag)));
                        }
                    }
                    actuallyShowingArticles = list;
                }
                else if (e.Node.Tag == null && e.Node.Parent != null)
                {
                    actuallyShowingArticles = new List<IArticle>();
                }
                else if (e.Node.Parent == unreadFeeds)
                {
                    actuallyShowingArticles = (manager.Articles((Feed)e.Node.Tag)).Where(x => !x.Read).ToList();
                }
                else if (e.Node.Parent != null && e.Node.Parent.Parent == categories)
                {
                    var list = new List<IArticle>();
                    list.AddRange((manager.Articles((Feed)e.Node.Tag)));
                    actuallyShowingArticles = list;
                }
                else if (e.Node.Parent == allFeeds)
                {
                    actuallyShowingArticles = manager.Articles((Feed)e.Node.Tag).ToList();
                }
                else if (e.Node.Parent == starredFeeds)
                {
                    actuallyShowingArticles = (manager.Articles((Feed)e.Node.Tag)).Where(x => x.Starred).ToList();
                }

                else if (e.Node == starredFeeds)
                {
                    var list = new List<IArticle>();
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        list.AddRange((manager.Articles((Feed)node.Tag)).Where(x => x.Starred));
                    }
                    actuallyShowingArticles = list;
                }
                else if (e.Node == unreadFeeds)
                {
                    var list = new List<IArticle>();
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        list.AddRange((manager.Articles((Feed)node.Tag)).Where(x => !x.Read));
                    }
                    actuallyShowingArticles = list;
                }
                else if (e.Node == allFeeds)
                {
                    var list = new List<IArticle>();
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        list.AddRange((manager.Articles((Feed)node.Tag)));
                    }
                    actuallyShowingArticles = list;
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
                    actuallyShowingArticles = set;
                }
                RefreshView();
            }
            catch
            {

            }
        }


        /// <summary>
        /// handler pro pridání odběru  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //znovu znasilnime RenameBox
            RenameBox rnb = new RenameBox("Zadej URL:");
            if (rnb.ShowDialog() == DialogResult.OK)
            {
                string url = rnb.NewName;
                try
                {
                    manager.SubscribeToURL(url);
                    UpdateTreeView();
                }
                catch (InformUserException ex)
                {
                    MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch
                {
                    MessageBox.Show("Neplatná adresa, zkuste prosim znovu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    toolStripButton1_Click(sender, e);
                }

            };
        }
		

        /// <summary>
        /// handle toolstrip menu, oznací selected clanky za prectene
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arguments</param>
        private void označPřečtenéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                manager.SetRead((IArticle)(item.Tag), true);
                item.Font = new System.Drawing.Font(item.Font, FontStyle.Regular);
            }
            UpdateTreeView();
        }

        /// <summary>
        /// handle toolstrip menu, oznací selected clanky za neprectene
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arguments</param>
        private void označNepřečtenéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                manager.SetRead((IArticle)(item.Tag), false);
                item.Font = new System.Drawing.Font(item.Font, FontStyle.Bold);
            }
            UpdateTreeView();
        }

        /// <summary>
        /// handle toolstrip menu, oznací selected clanky za oblibene
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arguments</param>
        private void oblíbenéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                manager.SetStarred((IArticle)(item.Tag), true);
                ((IArticle)item.Tag).Starred = !true;
                item.ImageIndex = 1;
            }
            UpdateTreeView();
        }

        /// <summary>
        /// handle toolstrip menu, odznací oblibenos selected clankum
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arguments</param>
        private void neoblíbenéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                manager.SetStarred((IArticle)(item.Tag), false); 
                ((IArticle)item.Tag).Starred = false;
                item.ImageIndex =  0;
            }
            UpdateTreeView();
        }

     

        /// <summary>
        /// implementuje realtimove vyhledavani se zpozděním
        /// </summary>
        private void search()
        {
            string text = toolStripTextBox1.Text;
            actuallyShowingArticles = manager.Search(text);
            if (actuallyShowingArticles.Count() < 1)
            {
                listView1.Items.Clear();
                actuallyShowingArticles = new List<IArticle>() { new Article("Nenalezeny žádné feedy", "", "", DateTime.Now) };

                treeView_Filters.SelectedNode = null;
                RefreshView();
                UpdateTreeView();
                listView1.Items[0].ForeColor = Color.Red;
                listView1.Items[0].ImageIndex = -1;
                return;
            }
            RefreshView();
        }

        /// <summary>
        /// handler zapina efekt zpozdeni realtimoveho vyhledavani, pri změně vyhledavaneho textu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            _canSearch = false;
            searchTimer.Stop();
            searchTimer.Interval = SEARCH_INTERVAL;
            searchTimer.Start();
            
        }

        /// <summary>
        /// handler resici odhlaseni odberu feedu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void odhlásitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(treeView_Filters.SelectedNode.Tag is IFeed))
            {
                MessageBox.Show("Tak takhle to nejde!");
                return;
            }
            Feed feed = (Feed)treeView_Filters.SelectedNode.Tag;
            manager.Unsubscribe(feed);
            
            UpdateTreeView();
            treeView_Filters.SelectedNode = unreadFeeds;

        }
    }
}
