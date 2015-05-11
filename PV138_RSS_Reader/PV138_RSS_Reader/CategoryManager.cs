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
    public partial class CategoryManager : Form
    {
        private List<Category> _categories;
        public CategoryManager(List<Category> categories)
        {
            _categories = categories;
            InitializeComponent();
            listBoxCategory.Items.AddRange(categories.ToArray());
        }

        private void button_addCategory_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button_AddFeed_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                Category selectedCategory = (Category)(((ListBox)sender).SelectedItem);
                listBox_Feeds.Items.Clear();
                button_RenameCategory.Enabled = true;
                if (selectedCategory.Feeds.Count() < 1) { return; }
                listBox_Feeds.Items.AddRange(selectedCategory.Feeds.ToArray());
                button_RenameFeed.Enabled = false;
                listBox_Feeds.Visible = button_RenameFeed.Visible = label_feeds.Visible = button_AddFeed.Visible = true;

                
            }
            else
            {
                button_RenameCategory.Enabled = false;
                button_RenameFeed.Enabled = false;
                listBox_Feeds.Visible = button_RenameFeed.Visible = label_feeds.Visible = button_AddFeed.Visible = false;
            }
        }

        private void button_RenameFeed_Click(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                button_RenameFeed.Enabled = true;
            }
            else
            {
                button_RenameFeed.Enabled = false;
            }

        }

        private void button_RenameCategory_Click(object sender, EventArgs e)
        {

            Category selectedCategory = (Category)(listBoxCategory.SelectedItem);
            RenameBox rb = new RenameBox();
            if (rb.ShowDialog() == DialogResult.OK)
            {
                selectedCategory.Name = rb.NewName;
            }
            listBoxCategory.Items.Clear();
            listBoxCategory.Items.AddRange(_categories.ToArray());
            listBoxCategory.SelectedItem = selectedCategory;
        }

        private void listBoxCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxCategory_SelectedIndexChanged(listBoxCategory, null);
            button_RenameCategory_Click(null, null);
        }

        private void listBox_Feeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void listBox_Feeds_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //TODO
        }
    }
}
