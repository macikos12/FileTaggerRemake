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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FileTaggerRemake
{
    public partial class FileSelectForm : Form
    {
        public string fileConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FileTagger\config";
        public string fileConfigDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FileTagger\";
        public FileSelectForm()
        {
            InitializeComponent();
        }
        private void filesListRefresh()
        {
            filesList.Items.Clear();
            string filesDir = File.ReadAllLines(fileConfigPath)[0];
            string[] files = Directory.GetFiles(filesDir);
            for(int i = 0; i < files.Length; i++)
            {
                filesList.Items.Add(Path.GetFileName(files[i]));
            }
        }
        private void changeDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileConfig = File.ReadAllLines(fileConfigPath);
                File.WriteAllText(fileConfigPath, dialog.SelectedPath);
                for(int i = 1;i < fileConfig.Length; i++)
                {
                    File.AppendAllText(fileConfigPath, Environment.NewLine + fileConfig[i]);
                }
                fileConfig = File.ReadAllLines(fileConfigPath);
                directoryLabel.Text = fileConfig[0];
            }
            filesListRefresh();
        }

        private void FileSelectForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(fileConfigPath))
            {
                Directory.CreateDirectory(fileConfigDir);
                using (FileStream fs = File.Create(fileConfigPath))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes(@"C:\");
                    fs.Write(title, 0, title.Length);
                }
            }
            string[] fileConfig = File.ReadAllLines(fileConfigPath);
            directoryLabel.Text = fileConfig[0];
            filesListRefresh();
        }

        private void filesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                nextButton_Click(sender, e);
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if(filesList.SelectedIndex == -1)
            {
                MessageBox.Show("You Have to select a file first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] files = Directory.GetFiles(directoryLabel.Text);
                string selectedFile = files[filesList.SelectedIndex];
                Form tagFiles = new TagFilesForm
                {
                    Tag = selectedFile
                };
                tagFiles.Show();
            }
            
        }

        private void FileSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void showSearchFilesBtn_Click(object sender, EventArgs e)
        {
            Form searchFiles = new SearchFilesForm();
            searchFiles.Show();
            Hide();
        }
    }
}
