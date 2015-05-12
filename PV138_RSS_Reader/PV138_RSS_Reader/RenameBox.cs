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
    public partial class RenameBox : Form
    {
        public string NewName { get; set; }
        public RenameBox(string title= "")
        {
            InitializeComponent();
            if (title != "")
            {
                label_title.Text = title;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_newText.Text))
            {
                MessageBox.Show("Jméno nemůže být prázdné!", "Fatální chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_newText.Focus();
                return;
            }

            NewName = textBox_newText.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
