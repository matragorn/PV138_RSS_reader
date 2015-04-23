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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25});
            this.menuStrip_MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_StatusBar = new System.Windows.Forms.StatusStrip();
            this.panel_MainContent = new System.Windows.Forms.Panel();
            this.splitContainer_Tree_MainContent = new System.Windows.Forms.SplitContainer();
            this.panel_TreeChanals = new System.Windows.Forms.Panel();
            this.splitContainer_Feeds_FeedDetails = new System.Windows.Forms.SplitContainer();
            this.panel_Feeds = new System.Windows.Forms.Panel();
            this.panel_FeedDetails = new System.Windows.Forms.Panel();
            this.toolStrip_ToolMenu = new System.Windows.Forms.ToolStrip();
            this.toolMenu_ExampleButton = new System.Windows.Forms.ToolStripButton();
            this.treeView_Chanels = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip_MainMenu.SuspendLayout();
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
            // menuStrip_MainMenu
            // 
            this.menuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            this.menuStrip_MainMenu.Size = new System.Drawing.Size(963, 24);
            this.menuStrip_MainMenu.TabIndex = 0;
            this.menuStrip_MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip_StatusBar
            // 
            this.statusStrip_StatusBar.Location = new System.Drawing.Point(0, 572);
            this.statusStrip_StatusBar.Name = "statusStrip_StatusBar";
            this.statusStrip_StatusBar.Size = new System.Drawing.Size(963, 22);
            this.statusStrip_StatusBar.TabIndex = 1;
            this.statusStrip_StatusBar.Text = "statusStrip1";
            // 
            // panel_MainContent
            // 
            this.panel_MainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_MainContent.Controls.Add(this.splitContainer_Tree_MainContent);
            this.panel_MainContent.Location = new System.Drawing.Point(0, 52);
            this.panel_MainContent.Name = "panel_MainContent";
            this.panel_MainContent.Size = new System.Drawing.Size(963, 517);
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
            this.splitContainer_Tree_MainContent.Size = new System.Drawing.Size(963, 517);
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
            this.panel_TreeChanals.Size = new System.Drawing.Size(246, 513);
            this.panel_TreeChanals.TabIndex = 0;
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
            this.splitContainer_Feeds_FeedDetails.Size = new System.Drawing.Size(709, 517);
            this.splitContainer_Feeds_FeedDetails.SplitterDistance = 250;
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
            this.panel_Feeds.Size = new System.Drawing.Size(705, 246);
            this.panel_Feeds.TabIndex = 0;
            // 
            // panel_FeedDetails
            // 
            this.panel_FeedDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_FeedDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FeedDetails.Location = new System.Drawing.Point(0, 0);
            this.panel_FeedDetails.Name = "panel_FeedDetails";
            this.panel_FeedDetails.Size = new System.Drawing.Size(705, 259);
            this.panel_FeedDetails.TabIndex = 0;
            // 
            // toolStrip_ToolMenu
            // 
            this.toolStrip_ToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenu_ExampleButton});
            this.toolStrip_ToolMenu.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_ToolMenu.Name = "toolStrip_ToolMenu";
            this.toolStrip_ToolMenu.Size = new System.Drawing.Size(963, 25);
            this.toolStrip_ToolMenu.TabIndex = 3;
            this.toolStrip_ToolMenu.Text = "toolStrip1";
            // 
            // toolMenu_ExampleButton
            // 
            this.toolMenu_ExampleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMenu_ExampleButton.Image = ((System.Drawing.Image)(resources.GetObject("toolMenu_ExampleButton.Image")));
            this.toolMenu_ExampleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMenu_ExampleButton.Name = "toolMenu_ExampleButton";
            this.toolMenu_ExampleButton.Size = new System.Drawing.Size(23, 22);
            this.toolMenu_ExampleButton.Text = "toolStripButton1";
            // 
            // treeView_Chanels
            // 
            this.treeView_Chanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Chanels.Location = new System.Drawing.Point(0, 0);
            this.treeView_Chanels.Name = "treeView_Chanels";
            treeNode14.Name = "Node0";
            treeNode14.Text = "Node0";
            treeNode15.Name = "Node4";
            treeNode15.Text = "Node4";
            treeNode16.Checked = true;
            treeNode16.Name = "Node5";
            treeNode16.Text = "Node5";
            treeNode17.Name = "Node6";
            treeNode17.Text = "Node6";
            treeNode18.Name = "Node1";
            treeNode18.Text = "Node1";
            treeNode19.Name = "Node7";
            treeNode19.Text = "Node7";
            treeNode20.Name = "Node8";
            treeNode20.Text = "Node8";
            treeNode21.Name = "Node9";
            treeNode21.Text = "Node9";
            treeNode22.Name = "Node2";
            treeNode22.Text = "Node2";
            treeNode23.Name = "Node10";
            treeNode23.Text = "Node10";
            treeNode24.Name = "Node11";
            treeNode24.Text = "Node11";
            treeNode25.Name = "Node12";
            treeNode25.Text = "Node12";
            treeNode26.Name = "Node3";
            treeNode26.Text = "Node3";
            this.treeView_Chanels.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode18,
            treeNode22,
            treeNode26});
            this.treeView_Chanels.Size = new System.Drawing.Size(246, 513);
            this.treeView_Chanels.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(705, 246);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Feed";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Key Word";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "nevim co...";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "nevim co 2...";
            this.columnHeader5.Width = 100;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 594);
            this.Controls.Add(this.toolStrip_ToolMenu);
            this.Controls.Add(this.panel_MainContent);
            this.Controls.Add(this.statusStrip_StatusBar);
            this.Controls.Add(this.menuStrip_MainMenu);
            this.MainMenuStrip = this.menuStrip_MainMenu;
            this.Name = "MainWindow";
            this.Text = "RSS Reader";
            this.menuStrip_MainMenu.ResumeLayout(false);
            this.menuStrip_MainMenu.PerformLayout();
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

        private System.Windows.Forms.MenuStrip menuStrip_MainMenu;
        private System.Windows.Forms.StatusStrip statusStrip_StatusBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel_MainContent;
        private System.Windows.Forms.SplitContainer splitContainer_Tree_MainContent;
        private System.Windows.Forms.ToolStrip toolStrip_ToolMenu;
        private System.Windows.Forms.ToolStripButton toolMenu_ExampleButton;
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
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

