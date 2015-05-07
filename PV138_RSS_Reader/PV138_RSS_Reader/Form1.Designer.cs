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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy s neprecitanymi clankami");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Unread", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy v kategorii");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Jeden feed moze byt vo viac kategoriach");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Vypisane vsetky kategorie", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Categories", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("All feeds", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Vypisane vsetky feedy,");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("kde ma nejaky clanok hviezdicku");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Starred", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            this.panel_MainContent = new System.Windows.Forms.Panel();
            this.splitContainer_Tree_MainContent = new System.Windows.Forms.SplitContainer();
            this.panel_TreeChanals = new System.Windows.Forms.Panel();
            this.treeView_Chanels = new System.Windows.Forms.TreeView();
            this.splitContainer_Feeds_FeedDetails = new System.Windows.Forms.SplitContainer();
            this.panel_Feeds = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_FeedDetails = new System.Windows.Forms.Panel();
            this.toolStrip_ToolMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel_MainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Tree_MainContent)).BeginInit();
            this.splitContainer_Tree_MainContent.Panel1.SuspendLayout();
            this.splitContainer_Tree_MainContent.Panel2.SuspendLayout();
            this.splitContainer_Tree_MainContent.SuspendLayout();
            this.panel_TreeChanals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Feeds_FeedDetails)).BeginInit();
            this.splitContainer_Feeds_FeedDetails.Panel1.SuspendLayout();
            this.splitContainer_Feeds_FeedDetails.Panel2.SuspendLayout();
            this.splitContainer_Feeds_FeedDetails.SuspendLayout();
            this.panel_Feeds.SuspendLayout();
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
            this.panel_MainContent.Size = new System.Drawing.Size(963, 568);
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
            this.splitContainer_Tree_MainContent.Panel1.Controls.Add(this.panel_TreeChanals);
            // 
            // splitContainer_Tree_MainContent.Panel2
            // 
            this.splitContainer_Tree_MainContent.Panel2.Controls.Add(this.splitContainer_Feeds_FeedDetails);
            this.splitContainer_Tree_MainContent.Size = new System.Drawing.Size(963, 568);
            this.splitContainer_Tree_MainContent.SplitterDistance = 250;
            this.splitContainer_Tree_MainContent.TabIndex = 4;
            this.splitContainer_Tree_MainContent.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_Tree_MainContent_SplitterMoved);
            this.splitContainer_Tree_MainContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer_Feeds_FeedDetails_MouseUp);
            // 
            // panel_TreeChanals
            // 
            this.panel_TreeChanals.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_TreeChanals.Controls.Add(this.treeView_Chanels);
            this.panel_TreeChanals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TreeChanals.Location = new System.Drawing.Point(0, 0);
            this.panel_TreeChanals.Name = "panel_TreeChanals";
            this.panel_TreeChanals.Size = new System.Drawing.Size(246, 564);
            this.panel_TreeChanals.TabIndex = 0;
            // 
            // treeView_Chanels
            // 
            this.treeView_Chanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Chanels.HideSelection = false;
            this.treeView_Chanels.Location = new System.Drawing.Point(0, 0);
            this.treeView_Chanels.Name = "treeView_Chanels";
            treeNode1.Name = "Vypisane vsetky feedy s neprecitanymi clankami";
            treeNode1.Text = "Vypisane vsetky feedy s neprecitanymi clankami";
            treeNode2.Name = "Unread";
            treeNode2.Text = "Unread";
            treeNode3.Name = "Vypisane vsetky feedy v kategorii";
            treeNode3.Text = "Vypisane vsetky feedy v kategorii";
            treeNode4.Name = "Jeden feed moze byt vo viac kategoriach";
            treeNode4.Text = "Jeden feed moze byt vo viac kategoriach";
            treeNode5.Name = "Vypisane vsetky kategorie";
            treeNode5.Text = "Vypisane vsetky kategorie";
            treeNode6.Name = "Categories";
            treeNode6.Text = "Categories";
            treeNode7.Name = "Vypisane vsetky feedy";
            treeNode7.Text = "Vypisane vsetky feedy";
            treeNode8.Name = "All feeds";
            treeNode8.Text = "All feeds";
            treeNode9.Name = "Vypisane vsetky feedy,";
            treeNode9.Text = "Vypisane vsetky feedy,";
            treeNode10.Name = "kde ma nejaky clanok hviezdicku";
            treeNode10.Text = "kde ma nejaky clanok hviezdicku";
            treeNode11.Name = "Starred";
            treeNode11.Text = "Starred";
            this.treeView_Chanels.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6,
            treeNode8,
            treeNode11});
            this.treeView_Chanels.ShowLines = false;
            this.treeView_Chanels.Size = new System.Drawing.Size(246, 564);
            this.treeView_Chanels.TabIndex = 0;
            this.treeView_Chanels.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Chanels_AfterSelect);
            // 
            // splitContainer_Feeds_FeedDetails
            // 
            this.splitContainer_Feeds_FeedDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer_Feeds_FeedDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Feeds_FeedDetails.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Feeds_FeedDetails.Name = "splitContainer_Feeds_FeedDetails";
            this.splitContainer_Feeds_FeedDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Feeds_FeedDetails.Panel1
            // 
            this.splitContainer_Feeds_FeedDetails.Panel1.Controls.Add(this.panel_Feeds);
            // 
            // splitContainer_Feeds_FeedDetails.Panel2
            // 
            this.splitContainer_Feeds_FeedDetails.Panel2.Controls.Add(this.panel_FeedDetails);
            this.splitContainer_Feeds_FeedDetails.Size = new System.Drawing.Size(709, 568);
            this.splitContainer_Feeds_FeedDetails.SplitterDistance = 274;
            this.splitContainer_Feeds_FeedDetails.TabIndex = 0;
            this.splitContainer_Feeds_FeedDetails.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_Feeds_FeedDetails_SplitterMoved);
            this.splitContainer_Feeds_FeedDetails.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer_Feeds_FeedDetails_MouseUp);
            // 
            // panel_Feeds
            // 
            this.panel_Feeds.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_Feeds.Controls.Add(this.listView1);
            this.panel_Feeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Feeds.Location = new System.Drawing.Point(0, 0);
            this.panel_Feeds.Name = "panel_Feeds";
            this.panel_Feeds.Size = new System.Drawing.Size(705, 270);
            this.panel_Feeds.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(705, 270);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Read";
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Starred";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 100;
            // 
            // panel_FeedDetails
            // 
            this.panel_FeedDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_FeedDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FeedDetails.Location = new System.Drawing.Point(0, 0);
            this.panel_FeedDetails.Name = "panel_FeedDetails";
            this.panel_FeedDetails.Size = new System.Drawing.Size(705, 286);
            this.panel_FeedDetails.TabIndex = 0;
            // 
            // toolStrip_ToolMenu
            // 
            this.toolStrip_ToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip_ToolMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_ToolMenu.Name = "toolStrip_ToolMenu";
            this.toolStrip_ToolMenu.Size = new System.Drawing.Size(963, 25);
            this.toolStrip_ToolMenu.Stretch = true;
            this.toolStrip_ToolMenu.TabIndex = 3;
            this.toolStrip_ToolMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(116, 22);
            this.toolStripButton1.Text = "Prihlasit novy odber";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(115, 22);
            this.toolStripButton2.Text = "Spravovat kategorie";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 597);
            this.Controls.Add(this.toolStrip_ToolMenu);
            this.Controls.Add(this.panel_MainContent);
            this.Name = "MainWindow";
            this.Text = "RSS Reader";
            this.panel_MainContent.ResumeLayout(false);
            this.splitContainer_Tree_MainContent.Panel1.ResumeLayout(false);
            this.splitContainer_Tree_MainContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Tree_MainContent)).EndInit();
            this.splitContainer_Tree_MainContent.ResumeLayout(false);
            this.panel_TreeChanals.ResumeLayout(false);
            this.splitContainer_Feeds_FeedDetails.Panel1.ResumeLayout(false);
            this.splitContainer_Feeds_FeedDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Feeds_FeedDetails)).EndInit();
            this.splitContainer_Feeds_FeedDetails.ResumeLayout(false);
            this.panel_Feeds.ResumeLayout(false);
            this.toolStrip_ToolMenu.ResumeLayout(false);
            this.toolStrip_ToolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_MainContent;
        private System.Windows.Forms.SplitContainer splitContainer_Tree_MainContent;
        private System.Windows.Forms.ToolStrip toolStrip_ToolMenu;
        private System.Windows.Forms.Panel panel_TreeChanals;
        private System.Windows.Forms.SplitContainer splitContainer_Feeds_FeedDetails;
        private System.Windows.Forms.Panel panel_Feeds;
        private System.Windows.Forms.Panel panel_FeedDetails;
        private System.Windows.Forms.TreeView treeView_Chanels;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

