using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileTaggerRemake
{
    public partial class TagFilesForm : Form
    {
        public string fileConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FileTagger\config";
        public string fileConfigDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FileTagger\";
        public string tagsFileName;
        public TagFilesForm()
        {
            InitializeComponent();
        }
        void setTagsFileName(string fileDirectory)
        {
            string[] directories = File.ReadAllLines(fileConfigPath);
            for(int i = 1; i < directories.Length; i++)
            {
                if (directories[i] == fileDirectory)
                {
                    tagsFileName = i.ToString();
                    return;
                }
            }
            tagsFileName = directories.Length.ToString();
            File.WriteAllText(fileConfigDir + tagsFileName, "");
            File.AppendAllText(fileConfigPath, Environment.NewLine + Tag.ToString());
        }
        void tagsListRefresh()
        {
            if (File.Exists(fileConfigDir + tagsFileName))
            {
                string[] fileTags = File.ReadAllLines(fileConfigDir + tagsFileName);
                for (int i = 0; i < fileTags.Length; i++)
                {
                    if (fileTags[i] != "")
                    {
                        tagsList.Items.Add(fileTags[i]);
                    }
                }
            }
        }
        void tagsComboBoxRefresh()
        {
            string[] tags = File.ReadAllLines(fileConfigDir + @"tags.tags");
            List<string> tagsInUse = new List<string>();
            for (int i = 1; i < File.ReadAllLines(fileConfigPath).Length; i++)
            {
                string[] tagsFile = File.ReadAllLines(fileConfigDir + i);
                for (int j = 0; j < tagsFile.Length; j++)
                {
                    tagsInUse.Add(tagsFile[j]);
                }
            }
            for (int i = 0; i < tags.Length; i++)
            {
                if (tagsInUse.Contains(tags[i]))
                {
                    tagsComboBox.Items.Add(tags[i]);
                }
            }
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
            Hide();
        }


        private void TagFiles_Load(object sender, EventArgs e)
        {
            if (!File.Exists(fileConfigDir + @"tags.tags"))
            {
                using (FileStream fs = File.Create(fileConfigDir + @"tags.tags")) { }
            }
            string selectedFiles = Tag.ToString();
            setTagsFileName(selectedFiles);
            tagsComboBoxRefresh();
            tagsListRefresh();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            string selectedFiles = Tag.ToString();
            System.Diagnostics.Process.Start(selectedFiles);
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            if(tagsComboBox.Text.Contains(";") || tagsComboBox.Text.Contains(" ") || tagsComboBox.Items.Contains(" "))
            {
                MessageBox.Show("Tags cannot contain spaces or semicolons", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(tagsComboBox.Text == string.Empty)
            {
                MessageBox.Show("You have to write something", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tagsList.Items.Contains(tagsComboBox.Text))
            {
                MessageBox.Show("This file already has this tag assigned to it", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tagsList.Items.Add(tagsComboBox.Text);
                if (!tagsComboBox.Items.Contains(tagsComboBox.Text))
                {
                    tagsComboBox.Items.Add(tagsComboBox.Text);
                }
            }
            tagsComboBox.Text = string.Empty;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileConfigDir + @"tags.tags", "");
            for (int i = 0; i < tagsComboBox.Items.Count; i++)
            {
                File.AppendAllText(fileConfigDir + @"tags.tags", tagsComboBox.Items[i] + Environment.NewLine);
            }
            File.WriteAllText(fileConfigDir + tagsFileName, "");
            for (int i = 0; i < tagsList.Items.Count; i++)
            {
                File.AppendAllText(fileConfigDir + tagsFileName, tagsList.Items[i] + Environment.NewLine);
            }
            Hide(); 
        }

        private void removeTagButton_Click(object sender, EventArgs e)
        {
            tagsList.Items.Remove(tagsList.SelectedItem);
        }
    }
}
