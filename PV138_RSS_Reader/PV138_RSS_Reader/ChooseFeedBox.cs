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
    public partial class ChooseFeedBox : Form
    {
        public Feed SelectedFeed { get; set; }
        public ChooseFeedBox(List<IFeed> feedsToChooseFrom)
        {
            InitializeComponent();
            listBox_FeedToChooseFrom.Items.AddRange(feedsToChooseFrom.ToArray());
        }

        private void listBox_FeedToChooseFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedFeed = (Feed)listBox_FeedToChooseFrom.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectedFeed != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nevybai jste žádný kanál!","chyba",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void listBox_FeedToChooseFrom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button1_Click(null, null);
        }
    }
}
