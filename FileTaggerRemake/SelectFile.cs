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
            string[] fileConfig = File.ReadAllLines(fileConfigPath);
            string[] files = Directory.GetFiles(fileConfig[0]);
            for(int i = 0; i < files.Length; i++)
            {
                filesList.Items.Add(files[i]);
            }
        }
        private void changeDirectoryButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                using (FileStream fs = File.Create(fileConfigPath))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes(dialog.FileName);
                    fs.Write(title, 0, title.Length);
                }

                string[] fileConfig = File.ReadAllLines(fileConfigPath);
                directoryLabel.Text = fileConfig[0];
            }
            filesListRefresh();
        }

        private void FileSelectForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(fileConfigPath)) {   }
            else
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
            if (filesList.SelectedIndex == -1) { }
            else
            {
                nextButton_Click(sender, e);
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if(filesList.SelectedIndex == -1)
            {
                MessageBox.Show("You Have to select a file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedFile = filesList.SelectedItem.ToString();
                Form tagFiles = new TagFiles();
                tagFiles.Tag = selectedFile;
                tagFiles.Show();
                this.Hide();
            }
            
        }

        private void FileSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
