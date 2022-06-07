using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTaggerRemake
{
    public partial class TagFiles : Form
    {

        public TagFiles()
        {
            InitializeComponent();
        }
        
        private void alwaysOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysOnTopCheckBox.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            Form fileSelectForm = new FileSelectForm();
            fileSelectForm.Show();
            this.Hide();
        }

        private void TagFiles_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TagFiles_Load(object sender, EventArgs e)
        {
            string selectedFiles = this.Tag.ToString();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            string selectedFiles = this.Tag.ToString();
            System.Diagnostics.Process.Start(selectedFiles);
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            if(tagsComboBox.Text.Contains(";") || tagsComboBox.Text.Contains(" "))
            {
                MessageBox.Show("Tags cannot contain spaces or semicolons", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tagsComboBox.Text == "")
            {
                MessageBox.Show("You have to write something", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tagsListbox.Items.Contains(tagsComboBox.Text))
            {
                MessageBox.Show("This file already has this tag assigned to it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tagsListbox.Items.Add(tagsComboBox.Text);
            }
        }
    }
}
