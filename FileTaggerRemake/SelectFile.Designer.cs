namespace FileTaggerRemake
{
    partial class FileSelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.changeDirectoryButton = new System.Windows.Forms.Button();
            this.filesList = new System.Windows.Forms.ListBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.showSearchFilesBtn = new System.Windows.Forms.Button();
            this.directoryTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changeDirectoryButton
            // 
            this.changeDirectoryButton.Location = new System.Drawing.Point(12, 8);
            this.changeDirectoryButton.Name = "changeDirectoryButton";
            this.changeDirectoryButton.Size = new System.Drawing.Size(122, 23);
            this.changeDirectoryButton.TabIndex = 0;
            this.changeDirectoryButton.Text = "Change files directory";
            this.changeDirectoryButton.UseVisualStyleBackColor = true;
            this.changeDirectoryButton.Click += new System.EventHandler(this.changeDirectoryButton_Click);
            // 
            // filesList
            // 
            this.filesList.AccessibleDescription = "";
            this.filesList.AccessibleName = "";
            this.filesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesList.FormattingEnabled = true;
            this.filesList.HorizontalScrollbar = true;
            this.filesList.Location = new System.Drawing.Point(12, 37);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(776, 368);
            this.filesList.TabIndex = 1;
            this.filesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filesList_MouseDoubleClick);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Location = new System.Drawing.Point(713, 415);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // showSearchFilesBtn
            // 
            this.showSearchFilesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showSearchFilesBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.showSearchFilesBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSearchFilesBtn.Location = new System.Drawing.Point(689, 8);
            this.showSearchFilesBtn.Name = "showSearchFilesBtn";
            this.showSearchFilesBtn.Size = new System.Drawing.Size(99, 23);
            this.showSearchFilesBtn.TabIndex = 4;
            this.showSearchFilesBtn.Text = "Search tagged files";
            this.showSearchFilesBtn.UseVisualStyleBackColor = true;
            this.showSearchFilesBtn.Click += new System.EventHandler(this.showSearchFilesBtn_Click);
            // 
            // directoryTxtBox
            // 
            this.directoryTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryTxtBox.Location = new System.Drawing.Point(140, 10);
            this.directoryTxtBox.Name = "directoryTxtBox";
            this.directoryTxtBox.ReadOnly = true;
            this.directoryTxtBox.Size = new System.Drawing.Size(543, 20);
            this.directoryTxtBox.TabIndex = 5;
            // 
            // FileSelectForm
            // 
            this.AcceptButton = this.nextButton;
            this.AccessibleDescription = "Select file to tag";
            this.AccessibleName = "File Tagger - Select File";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.showSearchFilesBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directoryTxtBox);
            this.Controls.Add(this.showSearchFilesBtn);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.changeDirectoryButton);
            this.MinimumSize = new System.Drawing.Size(278, 201);
            this.Name = "FileSelectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Tagger - Select File";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileSelectForm_FormClosed);
            this.Load += new System.EventHandler(this.FileSelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeDirectoryButton;
        private System.Windows.Forms.ListBox filesList;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button showSearchFilesBtn;
        private System.Windows.Forms.TextBox directoryTxtBox;
    }
}

