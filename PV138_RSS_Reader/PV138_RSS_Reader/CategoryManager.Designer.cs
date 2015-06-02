namespace PV138_RSS_Reader
{
    partial class CategoryManager
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
            this.button_addCategory = new System.Windows.Forms.Button();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_feeds = new System.Windows.Forms.Label();
            this.listBox_Feeds = new System.Windows.Forms.ListBox();
            this.button_AddFeed = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.button_RenameCategory = new System.Windows.Forms.Button();
            this.button_deleteFeed = new System.Windows.Forms.Button();
            this.button_deleteCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_addCategory
            // 
            this.button_addCategory.Location = new System.Drawing.Point(12, 258);
            this.button_addCategory.Name = "button_addCategory";
            this.button_addCategory.Size = new System.Drawing.Size(164, 23);
            this.button_addCategory.TabIndex = 3;
            this.button_addCategory.Text = "Přidat Kategorii";
            this.button_addCategory.UseVisualStyleBackColor = true;
            this.button_addCategory.Click += new System.EventHandler(this.button_addCategory_Click);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(12, 25);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(164, 199);
            this.listBoxCategory.TabIndex = 4;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            this.listBoxCategory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCategory_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategrie:";
            // 
            // label_feeds
            // 
            this.label_feeds.AutoSize = true;
            this.label_feeds.Location = new System.Drawing.Point(179, 9);
            this.label_feeds.Name = "label_feeds";
            this.label_feeds.Size = new System.Drawing.Size(42, 13);
            this.label_feeds.TabIndex = 8;
            this.label_feeds.Text = "Kanály:";
            this.label_feeds.Visible = false;
            // 
            // listBox_Feeds
            // 
            this.listBox_Feeds.FormattingEnabled = true;
            this.listBox_Feeds.Location = new System.Drawing.Point(182, 25);
            this.listBox_Feeds.Name = "listBox_Feeds";
            this.listBox_Feeds.Size = new System.Drawing.Size(164, 199);
            this.listBox_Feeds.TabIndex = 7;
            this.listBox_Feeds.Visible = false;
            this.listBox_Feeds.SelectedIndexChanged += new System.EventHandler(this.listBox_Feeds_SelectedIndexChanged);
            // 
            // button_AddFeed
            // 
            this.button_AddFeed.Location = new System.Drawing.Point(181, 230);
            this.button_AddFeed.Name = "button_AddFeed";
            this.button_AddFeed.Size = new System.Drawing.Size(164, 23);
            this.button_AddFeed.TabIndex = 6;
            this.button_AddFeed.Text = "Přidat Kanál";
            this.button_AddFeed.UseVisualStyleBackColor = true;
            this.button_AddFeed.Visible = false;
            this.button_AddFeed.Click += new System.EventHandler(this.button_AddFeed_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 315);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(334, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // button_RenameCategory
            // 
            this.button_RenameCategory.Enabled = false;
            this.button_RenameCategory.Location = new System.Drawing.Point(12, 229);
            this.button_RenameCategory.Name = "button_RenameCategory";
            this.button_RenameCategory.Size = new System.Drawing.Size(164, 23);
            this.button_RenameCategory.TabIndex = 10;
            this.button_RenameCategory.Text = "Přejmenovat Kategorii";
            this.button_RenameCategory.UseVisualStyleBackColor = true;
            this.button_RenameCategory.Click += new System.EventHandler(this.button_RenameCategory_Click);
            // 
            // button_deleteFeed
            // 
            this.button_deleteFeed.Location = new System.Drawing.Point(181, 259);
            this.button_deleteFeed.Name = "button_deleteFeed";
            this.button_deleteFeed.Size = new System.Drawing.Size(164, 23);
            this.button_deleteFeed.TabIndex = 13;
            this.button_deleteFeed.Text = "Odebrat Kanál";
            this.button_deleteFeed.UseVisualStyleBackColor = true;
            this.button_deleteFeed.Visible = false;
            this.button_deleteFeed.Click += new System.EventHandler(this.button_deleteFeed_Click);
            // 
            // button_deleteCategory
            // 
            this.button_deleteCategory.Enabled = false;
            this.button_deleteCategory.Location = new System.Drawing.Point(12, 286);
            this.button_deleteCategory.Name = "button_deleteCategory";
            this.button_deleteCategory.Size = new System.Drawing.Size(164, 23);
            this.button_deleteCategory.TabIndex = 12;
            this.button_deleteCategory.Text = "Smazat Kategorii";
            this.button_deleteCategory.UseVisualStyleBackColor = true;
            this.button_deleteCategory.Click += new System.EventHandler(this.button_deleteCategory_Click);
            // 
            // CategoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 350);
            this.ControlBox = false;
            this.Controls.Add(this.button_deleteFeed);
            this.Controls.Add(this.button_deleteCategory);
            this.Controls.Add(this.button_RenameCategory);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label_feeds);
            this.Controls.Add(this.listBox_Feeds);
            this.Controls.Add(this.button_AddFeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.button_addCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CategoryManager";
            this.Text = "Sprava Kategorií";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addCategory;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_feeds;
        private System.Windows.Forms.ListBox listBox_Feeds;
        private System.Windows.Forms.Button button_AddFeed;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button button_RenameCategory;
        private System.Windows.Forms.Button button_deleteFeed;
        private System.Windows.Forms.Button button_deleteCategory;
    }
}