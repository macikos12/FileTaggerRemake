namespace FileTaggerRemake
{
    partial class SearchFilesForm
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.filesList = new System.Windows.Forms.ListBox();
            this.tagFilesBtn = new System.Windows.Forms.Button();
            this.tagsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(632, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 21);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // filesList
            // 
            this.filesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesList.FormattingEnabled = true;
            this.filesList.Location = new System.Drawing.Point(12, 41);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(776, 368);
            this.filesList.TabIndex = 1;
            this.filesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filesList_MouseDoubleClick);
            // 
            // tagFilesBtn
            // 
            this.tagFilesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagFilesBtn.Location = new System.Drawing.Point(713, 14);
            this.tagFilesBtn.Name = "tagFilesBtn";
            this.tagFilesBtn.Size = new System.Drawing.Size(75, 21);
            this.tagFilesBtn.TabIndex = 2;
            this.tagFilesBtn.Text = "Tag Files";
            this.tagFilesBtn.UseVisualStyleBackColor = true;
            this.tagFilesBtn.Click += new System.EventHandler(this.tagFilesBtn_Click);
            // 
            // tagsComboBox
            // 
            this.tagsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tagsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tagsComboBox.FormattingEnabled = true;
            this.tagsComboBox.Location = new System.Drawing.Point(73, 14);
            this.tagsComboBox.Name = "tagsComboBox";
            this.tagsComboBox.Size = new System.Drawing.Size(553, 21);
            this.tagsComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter tags";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(713, 415);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 5;
            this.openFileBtn.Text = "Open";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // SearchFilesForm
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tagsComboBox);
            this.Controls.Add(this.tagFilesBtn);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.searchBtn);
            this.MinimumSize = new System.Drawing.Size(360, 256);
            this.Name = "SearchFilesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Tagger - SearchFiles";
            this.Load += new System.EventHandler(this.SearchFilesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox filesList;
        private System.Windows.Forms.Button tagFilesBtn;
        private System.Windows.Forms.ComboBox tagsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFileBtn;
    }
}