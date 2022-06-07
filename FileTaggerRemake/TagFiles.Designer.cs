namespace FileTaggerRemake
{
    partial class TagFiles
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
            this.backButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.addTagButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeTagButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tagsComboBox = new System.Windows.Forms.ComboBox();
            this.alwaysOnTopCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tagsListbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(713, 13);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            // 
            // addTagButton
            // 
            this.addTagButton.Location = new System.Drawing.Point(713, 42);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(75, 23);
            this.addTagButton.TabIndex = 2;
            this.addTagButton.Text = "Add";
            this.addTagButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(713, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // removeTagButton
            // 
            this.removeTagButton.Location = new System.Drawing.Point(568, 415);
            this.removeTagButton.Name = "removeTagButton";
            this.removeTagButton.Size = new System.Drawing.Size(75, 23);
            this.removeTagButton.TabIndex = 4;
            this.removeTagButton.Text = "Remove tag";
            this.removeTagButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add new tags";
            // 
            // tagsComboBox
            // 
            this.tagsComboBox.FormattingEnabled = true;
            this.tagsComboBox.Location = new System.Drawing.Point(91, 44);
            this.tagsComboBox.Name = "tagsComboBox";
            this.tagsComboBox.Size = new System.Drawing.Size(616, 21);
            this.tagsComboBox.TabIndex = 6;
            // 
            // alwaysOnTopCheckBox
            // 
            this.alwaysOnTopCheckBox.AutoSize = true;
            this.alwaysOnTopCheckBox.Location = new System.Drawing.Point(13, 420);
            this.alwaysOnTopCheckBox.Name = "alwaysOnTopCheckBox";
            this.alwaysOnTopCheckBox.Size = new System.Drawing.Size(92, 17);
            this.alwaysOnTopCheckBox.TabIndex = 7;
            this.alwaysOnTopCheckBox.Text = "Always on top";
            this.alwaysOnTopCheckBox.UseVisualStyleBackColor = true;
            this.alwaysOnTopCheckBox.CheckedChanged += new System.EventHandler(this.alwaysOnTopCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tagsListbox);
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 343);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tags";
            // 
            // tagsListbox
            // 
            this.tagsListbox.FormattingEnabled = true;
            this.tagsListbox.Location = new System.Drawing.Point(6, 19);
            this.tagsListbox.Name = "tagsListbox";
            this.tagsListbox.Size = new System.Drawing.Size(760, 316);
            this.tagsListbox.TabIndex = 0;
            // 
            // TagFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.alwaysOnTopCheckBox);
            this.Controls.Add(this.tagsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeTagButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addTagButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.backButton);
            this.Name = "TagFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tag Files";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TagFiles_FormClosed);
            this.Load += new System.EventHandler(this.TagFiles_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button addTagButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeTagButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tagsComboBox;
        private System.Windows.Forms.CheckBox alwaysOnTopCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox tagsListbox;
    }
}