using PV138_RSS_Reader.Exceptions;
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
        private FeedManager _feedManager;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="manager">manazer ktery spravuje feedy, ktere budeme radit do kategorii</param>
        public CategoryManager(FeedManager manager)
        {
            this._feedManager = manager;
            _categories = manager.Storage.GetCategories();
            InitializeComponent();
            listBoxCategory.Items.AddRange(_categories.ToArray());
        }
        /// <summary>
        /// handler pridani kategorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_addCategory_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)(listBoxCategory.SelectedItem);

            //trochu tu znasilním RenameBox
            RenameBox rb = new RenameBox("New Category:");
            if (rb.ShowDialog() == DialogResult.OK)
            {
                var c = new Category() { Name = rb.NewName, };
                _categories.Add(c);
                _feedManager.AddCategory(c);
            }
            listBoxCategory.Items.Clear();
            listBoxCategory.Items.AddRange(_categories.ToArray());
            listBoxCategory.SelectedItem = selectedCategory;
        }

        /// <summary>
        /// handler pridani feedu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddFeed_Click(object sender, EventArgs e)
        {
            if (_feedManager.Feeds.Count < 1)
            {
                MessageBox.Show("Nejste přihlašen k žádným odběrům!","Nelze přidat kanál do kategorie",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            ChooseFeedBox cfb = new ChooseFeedBox(_feedManager.Feeds);
            if (cfb.ShowDialog() == DialogResult.OK)
            {
                Category selectedCategory = ((Category)(listBoxCategory.SelectedItem));
                //selectedCategory.AddFeed(cfb.SelectedFeed);
                try
                {
                    _feedManager.AddFeedToCategory(selectedCategory, cfb.SelectedFeed);
                }
                catch (InformUserException ex)
                {
                    MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("chyba", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listBoxCategory.SelectedIndex = -1;
                listBoxCategory.SelectedItem = selectedCategory;
            }

        }

        /// <summary>
        /// handle OK click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// handler pro zmenu upravovane kategorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategory.SelectedIndex != -1)
            {
                Category selectedCategory = (Category)(((ListBox)sender).SelectedItem);
                listBox_Feeds.Items.Clear();
                button_RenameCategory.Enabled = true;
                button_deleteCategory.Enabled = true;
                //if (selectedCategory.Feeds.Count() < 1) { return; }
                listBox_Feeds.Items.AddRange(selectedCategory.Feeds.ToArray());
                button_deleteFeed.Enabled = false;
                listBox_Feeds.Visible = button_deleteFeed.Visible = label_feeds.Visible = button_AddFeed.Visible = true;
                listBox_Feeds.SelectedIndex = listBox_Feeds.Items.Count - 1;

            }
            else
            {
                button_deleteCategory.Enabled = false;
                button_deleteFeed.Enabled = false;
                button_RenameCategory.Enabled = false;
                listBox_Feeds.Visible = button_deleteFeed.Visible = label_feeds.Visible = button_AddFeed.Visible = false;
            }
        }
        /// <summary>
        /// hanler prejmenovani kategorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_RenameCategory_Click(object sender, EventArgs e)
        {

            Category selectedCategory = (Category)(listBoxCategory.SelectedItem);
            RenameBox rb = new RenameBox();
            if (rb.ShowDialog() == DialogResult.OK)
            {
                selectedCategory.Name = rb.NewName;
                _feedManager.RenameCategory(selectedCategory, rb.NewName);
            }
            listBoxCategory.Items.Clear();
            listBoxCategory.Items.AddRange(_categories.ToArray());
            listBoxCategory.SelectedItem = selectedCategory;
        }

        /// <summary>
        /// handelr vyberu categorie doubleclickem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxCategory_SelectedIndexChanged(listBoxCategory, null);
            button_RenameCategory_Click(null, null);
        }

        /// <summary>
        /// handler vyberu feedu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Feeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            Feed SelectedFeed = listBox_Feeds.SelectedItem as Feed;
            if (SelectedFeed == null)
            {
                button_deleteFeed.Enabled = false;
                return;
            }
            else
            {
                button_deleteFeed.Enabled = true;
            }
        }

   /// <summary>
   /// handler mazani kategorie
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
        private void button_deleteCategory_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)(listBoxCategory.SelectedItem);
            if (selectedCategory == null)
            {
                return;
            }
            _categories.Remove(selectedCategory);
            _feedManager.RemoveCategory(selectedCategory);
            listBoxCategory.SelectedIndex = -1;
            listBoxCategory.Items.Clear();
            listBoxCategory.Items.AddRange(_categories.ToArray());
        }

        /// <summary>
        /// handler mazani feedu z kategorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_deleteFeed_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)(listBoxCategory.SelectedItem);
            if (selectedCategory == null)
            {
                return;
            }
            _feedManager.RemoveFeedFromCategory(selectedCategory, (listBox_Feeds.SelectedItem as Feed));
            listBoxCategory.SelectedIndex = -1;
            listBoxCategory.SelectedItem = selectedCategory;
        }
    }
}
