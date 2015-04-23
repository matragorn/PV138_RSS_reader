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
            this.menuStrip_MainMenu.SuspendLayout();
            this.panel_MainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Tree_MainContent)).BeginInit();
            this.splitContainer_Tree_MainContent.Panel1.SuspendLayout();
            this.splitContainer_Tree_MainContent.Panel2.SuspendLayout();
            this.splitContainer_Tree_MainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Feeds_FeedDetails)).BeginInit();
            this.splitContainer_Feeds_FeedDetails.Panel1.SuspendLayout();
            this.splitContainer_Feeds_FeedDetails.Panel2.SuspendLayout();
            this.splitContainer_Feeds_FeedDetails.SuspendLayout();
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
            this.splitContainer_Tree_MainContent.SplitterDistance = 321;
            this.splitContainer_Tree_MainContent.TabIndex = 4;
            this.splitContainer_Tree_MainContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer_Feeds_FeedDetails_MouseUp);
            // 
            // panel_TreeChanals
            // 
            this.panel_TreeChanals.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_TreeChanals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TreeChanals.Location = new System.Drawing.Point(0, 0);
            this.panel_TreeChanals.Name = "panel_TreeChanals";
            this.panel_TreeChanals.Size = new System.Drawing.Size(317, 513);
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
            this.splitContainer_Feeds_FeedDetails.Size = new System.Drawing.Size(638, 517);
            this.splitContainer_Feeds_FeedDetails.SplitterDistance = 212;
            this.splitContainer_Feeds_FeedDetails.TabIndex = 0;
            this.splitContainer_Feeds_FeedDetails.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer_Feeds_FeedDetails_MouseUp);
            // 
            // panel_Feeds
            // 
            this.panel_Feeds.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_Feeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Feeds.Location = new System.Drawing.Point(0, 0);
            this.panel_Feeds.Name = "panel_Feeds";
            this.panel_Feeds.Size = new System.Drawing.Size(634, 208);
            this.panel_Feeds.TabIndex = 0;
            // 
            // panel_FeedDetails
            // 
            this.panel_FeedDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_FeedDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FeedDetails.Location = new System.Drawing.Point(0, 0);
            this.panel_FeedDetails.Name = "panel_FeedDetails";
            this.panel_FeedDetails.Size = new System.Drawing.Size(634, 297);
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
            this.splitContainer_Feeds_FeedDetails.Panel1.ResumeLayout(false);
            this.splitContainer_Feeds_FeedDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Feeds_FeedDetails)).EndInit();
            this.splitContainer_Feeds_FeedDetails.ResumeLayout(false);
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
    }
}

