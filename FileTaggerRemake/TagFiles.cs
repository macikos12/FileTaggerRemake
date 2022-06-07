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
    }
}
