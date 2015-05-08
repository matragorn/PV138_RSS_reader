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
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy s neprecitanymi clankami");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Unread", new System.Windows.Forms.TreeNode[] {
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy v kategorii");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Jeden feed moze byt vo viac kategoriach");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Vypisane vsetky kategorie", new System.Windows.Forms.TreeNode[] {
            treeNode102,
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Categories", new System.Windows.Forms.TreeNode[] {
            treeNode104});
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("All feeds", new System.Windows.Forms.TreeNode[] {
            treeNode106});
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy,");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("kde ma nejaky clanok hviezdicku");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Starred", new System.Windows.Forms.TreeNode[] {
            treeNode108,
            treeNode109});
            this.panel_MainContent = new System.Windows.Forms.Panel();
            this.splitContainer_Tree_MainContent = new System.Windows.Forms.SplitContainer();
            this.panel_TreeFilters = new System.Windows.Forms.Panel();
            this.treeView_Filters = new System.Windows.Forms.TreeView();
            this.splitContainer_FilterView_ArticleView = new System.Windows.Forms.SplitContainer();
            this.panel_FilterView = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Read = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Starred = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip_ToolMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.panel_MainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Tree_MainContent)).BeginInit();
            this.splitContainer_Tree_MainContent.Panel1.SuspendLayout();
            this.splitContainer_Tree_MainContent.Panel2.SuspendLayout();
            this.splitContainer_Tree_MainContent.SuspendLayout();
            this.panel_TreeFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FilterView_ArticleView)).BeginInit();
            this.splitContainer_FilterView_ArticleView.Panel1.SuspendLayout();
            this.splitContainer_FilterView_ArticleView.Panel2.SuspendLayout();
            this.splitContainer_FilterView_ArticleView.SuspendLayout();
            this.panel_FilterView.SuspendLayout();
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
            this.treeView_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Filters.HideSelection = false;
            this.treeView_Filters.Location = new System.Drawing.Point(0, 0);
            this.treeView_Filters.Name = "treeView_Filters";
            treeNode100.Name = "Vypisane vsetky feedy s neprecitanymi clankami";
            treeNode100.Text = "Vypisane vsetky feedy s neprecitanymi clankami";
            treeNode101.Name = "Unread";
            treeNode101.Text = "Unread";
            treeNode102.Name = "Vypisane vsetky feedy v kategorii";
            treeNode102.Text = "Vypisane vsetky feedy v kategorii";
            treeNode103.Name = "Jeden feed moze byt vo viac kategoriach";
            treeNode103.Text = "Jeden feed moze byt vo viac kategoriach";
            treeNode104.Name = "Vypisane vsetky kategorie";
            treeNode104.Text = "Vypisane vsetky kategorie";
            treeNode105.Name = "Categories";
            treeNode105.Text = "Categories";
            treeNode106.Name = "Vypisane vsetky feedy";
            treeNode106.Text = "Vypisane vsetky feedy";
            treeNode107.Name = "All feeds";
            treeNode107.Text = "All feeds";
            treeNode108.Name = "Vypisane vsetky feedy,";
            treeNode108.Text = "Vypisane vsetky feedy,";
            treeNode109.Name = "kde ma nejaky clanok hviezdicku";
            treeNode109.Text = "kde ma nejaky clanok hviezdicku";
            treeNode110.Name = "Starred";
            treeNode110.Text = "Starred";
            this.treeView_Filters.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode105,
            treeNode107,
            treeNode110});
            this.treeView_Filters.ShowLines = false;
            this.treeView_Filters.Size = new System.Drawing.Size(297, 566);
            this.treeView_Filters.TabIndex = 0;
            this.treeView_Filters.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Chanels_AfterSelect);
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
            this.Read,
            this.Starred,
            this.Date,
            this.Title});
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
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Read
            // 
            this.Read.Text = "Read";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 115;
            // 
            // Starred
            // 
            this.Starred.Text = "Starred";
            this.Starred.Width = 55;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 592;
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
            this.RefreshButton});
            this.toolStrip_ToolMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_ToolMenu.Name = "toolStrip_ToolMenu";
            this.toolStrip_ToolMenu.Size = new System.Drawing.Size(1135, 25);
            this.toolStrip_ToolMenu.Stretch = true;
            this.toolStrip_ToolMenu.TabIndex = 3;
            this.toolStrip_ToolMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(116, 22);
            this.toolStripButton1.Text = "Prihlasit novy odber";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(115, 22);
            this.toolStripButton2.Text = "Spravovat kategorie";
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(50, 22);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            this.splitContainer_FilterView_ArticleView.Panel1.ResumeLayout(false);
            this.splitContainer_FilterView_ArticleView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FilterView_ArticleView)).EndInit();
            this.splitContainer_FilterView_ArticleView.ResumeLayout(false);
            this.panel_FilterView.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader Starred;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Read;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton RefreshButton;
    }
}

