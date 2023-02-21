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
    public partial class SearchFilesForm : Form
    {
        public string fileConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FileTagger\config";
        public string fileConfigDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FileTagger\";

        public SearchFilesForm()
        {
            InitializeComponent();
        }

        void tagsComboBoxRefresh()
        {
            string[] tags = File.ReadAllLines(fileConfigDir + @"tags.tags");
            for (int i = 0; i < tags.Length; i++)
            {
                tagsComboBox.Items.Add(tags[i]);
            }
        }

        bool checkIfArrayContains(string[,] array, string word, int number)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[number, i] == word)
                {
                    return true;
                }
            }
            return false;
        }

        void filesListRefresh(string[] searchTags = null)
        {
            filesList.Items.Clear();
            string[] files = File.ReadAllLines(fileConfigPath);
            string[] tags = File.ReadAllLines(fileConfigDir + @"tags.tags");
            if (searchTags == null)
            {
                for (int i = 1; i < files.Length; i++)
                {
                    filesList.Items.Add(files[i]);
                }
            }
            else
            {
                string[,] filesTags = new string[files.Length, tags.Length];
                for (int i = 1; i < files.Length; i++)
                {
                    string[] fileTags = File.ReadAllLines(fileConfigDir + i);
                    for (int j = 0; j < fileTags.Length; j++)
                    {
                        filesTags[i, j] = fileTags[j];
                    }
                }
                for(int i = 1; i < files.Length; i++)
                {
                    bool isStillGood = true;
                    for(int j = 0; j < searchTags.Length; j++)
                    {
                        if (!checkIfArrayContains(filesTags, searchTags[j], i))
                        {
                            isStillGood = false;
                        }
                        if(isStillGood && j == searchTags.Length - 1)
                        {
                            filesList.Items.Add(files[i]);
                        }
                    }
                }
            }
        }

        private void tagFilesBtn_Click(object sender, EventArgs e)
        {
            Form selectFile = new FileSelectForm();
            selectFile.Show();
            Hide();
        }

        private void SearchFilesForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(fileConfigDir + @"tags.tags"))
            {
                tagsComboBoxRefresh();
                filesListRefresh();
            }
            else
            {
                searchBtn.Enabled = false;
                openFileBtn.Enabled = false;
                filesList.Items.Add("It seems you have not tagged any files yet");
            }
        }

        private void filesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openFileBtn_Click(sender, e);
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if(searchBtn.Enabled != false && filesList.SelectedIndex != -1)
            {
                System.Diagnostics.Process.Start(filesList.SelectedItem.ToString());
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            filesListRefresh(tagsComboBox.Text.Split(' '));
        }
    }
}
