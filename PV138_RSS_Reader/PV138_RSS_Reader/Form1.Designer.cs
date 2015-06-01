namespace PV138_RSS_Reader
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy s neprecitanymi clankami");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nepřečtené", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy v kategorii");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Jeden feed moze byt vo viac kategoriach");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Vypisane vsetky kategorie", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Kategorie", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Všechny kanály", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy,");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("kde ma nejaky clanok hviezdicku");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Oblíbené", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            this.panel_MainContent = new System.Windows.Forms.Panel();
            this.splitContainer_Tree_MainContent = new System.Windows.Forms.SplitContainer();
            this.panel_TreeFilters = new System.Windows.Forms.Panel();
            this.treeView_Filters = new System.Windows.Forms.TreeView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.odhlásitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer_FilterView_ArticleView = new System.Windows.Forms.SplitContainer();
            this.panel_FilterView = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.označPřečtenéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.označNepřečtenéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oblíbenéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neoblíbenéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip_ToolMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel_MainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Tree_MainContent)).BeginInit();
            this.splitContainer_Tree_MainContent.Panel1.SuspendLayout();
            this.splitContainer_Tree_MainContent.Panel2.SuspendLayout();
            this.splitContainer_Tree_MainContent.SuspendLayout();
            this.panel_TreeFilters.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FilterView_ArticleView)).BeginInit();
            this.splitContainer_FilterView_ArticleView.Panel1.SuspendLayout();
            this.splitContainer_FilterView_ArticleView.Panel2.SuspendLayout();
            this.splitContainer_FilterView_ArticleView.SuspendLayout();
            this.panel_FilterView.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip_ToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MainContent
            // 
            this.panel_MainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_MainContent.Controls.Add(this.splitContainer_Tree_MainContent);
            this.panel_MainContent.Location = new System.Drawing.Point(0, 28);
            this.panel_MainContent.Name = "panel_MainContent";
            this.panel_MainContent.Size = new System.Drawing.Size(1135, 570);
            this.panel_MainContent.TabIndex = 2;
            // 
            // splitContainer_Tree_MainContent
            // 
            this.splitContainer_Tree_MainContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer_Tree_MainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Tree_MainContent.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Tree_MainContent.Name = "splitContainer_Tree_MainContent";
            // 
            // splitContainer_Tree_MainContent.Panel1
            // 
            this.splitContainer_Tree_MainContent.Panel1.Controls.Add(this.panel_TreeFilters);
            // 
            // splitContainer_Tree_MainContent.Panel2
            // 
            this.splitContainer_Tree_MainContent.Panel2.Controls.Add(this.splitContainer_FilterView_ArticleView);
            this.splitContainer_Tree_MainContent.Size = new System.Drawing.Size(1135, 570);
            this.splitContainer_Tree_MainContent.SplitterDistance = 301;
            this.splitContainer_Tree_MainContent.TabIndex = 4;
            this.splitContainer_Tree_MainContent.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_Tree_MainContent_SplitterMoved);
            this.splitContainer_Tree_MainContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer_Feeds_FeedDetails_MouseUp);
            // 
            // panel_TreeFilters
            // 
            this.panel_TreeFilters.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_TreeFilters.Controls.Add(this.treeView_Filters);
            this.panel_TreeFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TreeFilters.Location = new System.Drawing.Point(0, 0);
            this.panel_TreeFilters.Name = "panel_TreeFilters";
            this.panel_TreeFilters.Size = new System.Drawing.Size(297, 566);
            this.panel_TreeFilters.TabIndex = 0;
            // 
            // treeView_Filters
            // 
            this.treeView_Filters.ContextMenuStrip = this.contextMenuStrip2;
            this.treeView_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Filters.HideSelection = false;
            this.treeView_Filters.Location = new System.Drawing.Point(0, 0);
            this.treeView_Filters.Name = "treeView_Filters";
            treeNode1.Name = "Vypisane vsetky feedy s neprecitanymi clankami";
            treeNode1.Text = "Vypisane vsetky feedy s neprecitanymi clankami";
            treeNode2.Name = "Unread";
            treeNode2.Text = "Nepřečtené";
            treeNode3.Name = "Vypisane vsetky feedy v kategorii";
            treeNode3.Text = "Vypisane vsetky feedy v kategorii";
            treeNode4.Name = "Jeden feed moze byt vo viac kategoriach";
            treeNode4.Text = "Jeden feed moze byt vo viac kategoriach";
            treeNode5.Name = "Vypisane vsetky kategorie";
            treeNode5.Text = "Vypisane vsetky kategorie";
            treeNode6.Name = "Categories";
            treeNode6.Text = "Kategorie";
            treeNode7.Name = "Vypisane vsetky feedy";
            treeNode7.Text = "Vypisane vsetky feedy";
            treeNode8.Name = "All feeds";
            treeNode8.Text = "Všechny kanály";
            treeNode9.Name = "Vypisane vsetky feedy,";
            treeNode9.Text = "Vypisane vsetky feedy,";
            treeNode10.Name = "kde ma nejaky clanok hviezdicku";
            treeNode10.Text = "kde ma nejaky clanok hviezdicku";
            treeNode11.Name = "Starred";
            treeNode11.Text = "Oblíbené";
            this.treeView_Filters.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6,
            treeNode8,
            treeNode11});
            this.treeView_Filters.ShowLines = false;
            this.treeView_Filters.Size = new System.Drawing.Size(297, 566);
            this.treeView_Filters.TabIndex = 0;
            this.treeView_Filters.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Filters_AfterSelect);
            
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odhlásitToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 48);
           
            // 
            // odhlásitToolStripMenuItem
            // 
            this.odhlásitToolStripMenuItem.Name = "odhlásitToolStripMenuItem";
            this.odhlásitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.odhlásitToolStripMenuItem.Text = "Odhlásit";
            this.odhlásitToolStripMenuItem.Click += new System.EventHandler(this.odhlásitToolStripMenuItem_Click);
            // 
            // splitContainer_FilterView_ArticleView
            // 
            this.splitContainer_FilterView_ArticleView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer_FilterView_ArticleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_FilterView_ArticleView.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_FilterView_ArticleView.Name = "splitContainer_FilterView_ArticleView";
            this.splitContainer_FilterView_ArticleView.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_FilterView_ArticleView.Panel1
            // 
            this.splitContainer_FilterView_ArticleView.Panel1.Controls.Add(this.panel_FilterView);
            // 
            // splitContainer_FilterView_ArticleView.Panel2
            // 
            this.splitContainer_FilterView_ArticleView.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer_FilterView_ArticleView.Size = new System.Drawing.Size(830, 570);
            this.splitContainer_FilterView_ArticleView.SplitterDistance = 275;
            this.splitContainer_FilterView_ArticleView.TabIndex = 0;
            this.splitContainer_FilterView_ArticleView.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_Feeds_FeedDetails_SplitterMoved);
            this.splitContainer_FilterView_ArticleView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer_Feeds_FeedDetails_MouseUp);
            // 
            // panel_FilterView
            // 
            this.panel_FilterView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_FilterView.Controls.Add(this.listView1);
            this.panel_FilterView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FilterView.Location = new System.Drawing.Point(0, 0);
            this.panel_FilterView.Name = "panel_FilterView";
            this.panel_FilterView.Size = new System.Drawing.Size(826, 271);
            this.panel_FilterView.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Title,
            this.columnHeaderFeed});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(826, 271);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Date
            // 
            this.Date.Text = "      Date";
            this.Date.Width = 115;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 400;
            // 
            // columnHeaderFeed
            // 
            this.columnHeaderFeed.Text = "Feed";
            this.columnHeaderFeed.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.označPřečtenéToolStripMenuItem,
            this.označNepřečtenéToolStripMenuItem,
            this.oblíbenéToolStripMenuItem,
            this.neoblíbenéToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 92);
            // 
            // označPřečtenéToolStripMenuItem
            // 
            this.označPřečtenéToolStripMenuItem.Name = "označPřečtenéToolStripMenuItem";
            this.označPřečtenéToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.označPřečtenéToolStripMenuItem.Text = "Označ Přečtené";
            this.označPřečtenéToolStripMenuItem.Click += new System.EventHandler(this.označPřečtenéToolStripMenuItem_Click);
            // 
            // označNepřečtenéToolStripMenuItem
            // 
            this.označNepřečtenéToolStripMenuItem.Name = "označNepřečtenéToolStripMenuItem";
            this.označNepřečtenéToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.označNepřečtenéToolStripMenuItem.Text = "Označ Nepřečtené";
            this.označNepřečtenéToolStripMenuItem.Click += new System.EventHandler(this.označNepřečtenéToolStripMenuItem_Click);
            // 
            // oblíbenéToolStripMenuItem
            // 
            this.oblíbenéToolStripMenuItem.Name = "oblíbenéToolStripMenuItem";
            this.oblíbenéToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.oblíbenéToolStripMenuItem.Text = "Označ Oblíbené";
            this.oblíbenéToolStripMenuItem.Click += new System.EventHandler(this.oblíbenéToolStripMenuItem_Click);
            // 
            // neoblíbenéToolStripMenuItem
            // 
            this.neoblíbenéToolStripMenuItem.Name = "neoblíbenéToolStripMenuItem";
            this.neoblíbenéToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.neoblíbenéToolStripMenuItem.Text = "Označ Neoblíbené";
            this.neoblíbenéToolStripMenuItem.Click += new System.EventHandler(this.neoblíbenéToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(826, 287);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // toolStrip_ToolMenu
            // 
            this.toolStrip_ToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.RefreshButton,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip_ToolMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_ToolMenu.Name = "toolStrip_ToolMenu";
            this.toolStrip_ToolMenu.Size = new System.Drawing.Size(1135, 26);
            this.toolStrip_ToolMenu.Stretch = true;
            this.toolStrip_ToolMenu.TabIndex = 3;
            this.toolStrip_ToolMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(116, 23);
            this.toolStripButton1.Text = "Prihlasit novy odber";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(115, 23);
            this.toolStripButton2.Text = "Spravovat kategorie";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(76, 23);
            this.RefreshButton.Text = "Aktualizovat";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 23);
            
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 23);
            this.toolStripLabel1.Text = "Hledej:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 599);
            this.Controls.Add(this.toolStrip_ToolMenu);
            this.Controls.Add(this.panel_MainContent);
            this.Name = "MainWindow";
            this.Text = "RSS Reader";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel_MainContent.ResumeLayout(false);
            this.splitContainer_Tree_MainContent.Panel1.ResumeLayout(false);
            this.splitContainer_Tree_MainContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Tree_MainContent)).EndInit();
            this.splitContainer_Tree_MainContent.ResumeLayout(false);
            this.panel_TreeFilters.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.splitContainer_FilterView_ArticleView.Panel1.ResumeLayout(false);
            this.splitContainer_FilterView_ArticleView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FilterView_ArticleView)).EndInit();
            this.splitContainer_FilterView_ArticleView.ResumeLayout(false);
            this.panel_FilterView.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip_ToolMenu.ResumeLayout(false);
            this.toolStrip_ToolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel_MainContent;
        private System.Windows.Forms.SplitContainer splitContainer_Tree_MainContent;
        private System.Windows.Forms.ToolStrip toolStrip_ToolMenu;
        private System.Windows.Forms.Panel panel_TreeFilters;
        private System.Windows.Forms.SplitContainer splitContainer_FilterView_ArticleView;
        private System.Windows.Forms.Panel panel_FilterView;
        private System.Windows.Forms.TreeView treeView_Filters;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ColumnHeader columnHeaderFeed;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem označPřečtenéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem označNepřečtenéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oblíbenéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neoblíbenéToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem odhlásitToolStripMenuItem;
    }
}

