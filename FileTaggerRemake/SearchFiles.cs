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

        void filesListRefresh(string tags)
        {
            filesList.Items.Clear();
            string[] files = File.ReadAllLines(fileConfigPath);
            if(tags == "")
            {
                for (int i = 1; i < files.Length; i++)
                {
                    filesList.Items.Add(files[i]);
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
                filesListRefresh("");
            }
        }

        private void filesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openFileBtn_Click(sender, e);
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if(filesList.SelectedIndex != -1)
            {
                System.Diagnostics.Process.Start(filesList.SelectedItem.ToString());
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            filesListRefresh(tagsComboBox.Text);
        }
    }
}
