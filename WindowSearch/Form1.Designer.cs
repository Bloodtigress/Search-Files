namespace WindowSearch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            DirectoryTB = new TextBox();
            DirectoryB = new Button();
            label2 = new Label();
            TextToSearchTB = new TextBox();
            FileListPanel = new Panel();
            NothingFoundLabel = new Label();
            SearchB = new Button();
            QuitB = new Button();
            FileNameCB = new CheckBox();
            FileContentCB = new CheckBox();
            ExtensionTooCB = new CheckBox();
            CurrentFileLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 55);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 0;
            label1.Text = "Current directory to search";
            // 
            // DirectoryTB
            // 
            DirectoryTB.Location = new Point(289, 52);
            DirectoryTB.Name = "DirectoryTB";
            DirectoryTB.Size = new Size(491, 31);
            DirectoryTB.TabIndex = 1;
            // 
            // DirectoryB
            // 
            DirectoryB.Image = Properties.Resources.FileImage;
            DirectoryB.Location = new Point(242, 46);
            DirectoryB.Name = "DirectoryB";
            DirectoryB.Size = new Size(41, 43);
            DirectoryB.TabIndex = 2;
            DirectoryB.UseVisualStyleBackColor = true;
            DirectoryB.Click += DirectoryB_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 113);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 3;
            label2.Text = "Text to search";
            // 
            // TextToSearchTB
            // 
            TextToSearchTB.Location = new Point(289, 107);
            TextToSearchTB.Name = "TextToSearchTB";
            TextToSearchTB.Size = new Size(491, 31);
            TextToSearchTB.TabIndex = 4;
            // 
            // FileListPanel
            // 
            FileListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FileListPanel.AutoScroll = true;
            FileListPanel.BackColor = SystemColors.AppWorkspace;
            FileListPanel.Location = new Point(786, 12);
            FileListPanel.Name = "FileListPanel";
            FileListPanel.Size = new Size(1384, 437);
            FileListPanel.TabIndex = 5;
            // 
            // NothingFoundLabel
            // 
            NothingFoundLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NothingFoundLabel.AutoSize = true;
            NothingFoundLabel.Font = new Font("Segoe UI", 30F);
            NothingFoundLabel.ForeColor = Color.IndianRed;
            NothingFoundLabel.Location = new Point(190, 270);
            NothingFoundLabel.Name = "NothingFoundLabel";
            NothingFoundLabel.Size = new Size(426, 81);
            NothingFoundLabel.TabIndex = 1;
            NothingFoundLabel.Text = "Nothing found";
            // 
            // SearchB
            // 
            SearchB.Location = new Point(327, 233);
            SearchB.Name = "SearchB";
            SearchB.Size = new Size(112, 34);
            SearchB.TabIndex = 6;
            SearchB.Text = "Search";
            SearchB.UseVisualStyleBackColor = true;
            SearchB.Click += SearchB_Click;
            // 
            // QuitB
            // 
            QuitB.Location = new Point(668, 184);
            QuitB.Name = "QuitB";
            QuitB.Size = new Size(112, 34);
            QuitB.TabIndex = 7;
            QuitB.Text = "Quit";
            QuitB.UseVisualStyleBackColor = true;
            QuitB.Click += QuitB_Click;
            // 
            // FileNameCB
            // 
            FileNameCB.AutoSize = true;
            FileNameCB.Checked = true;
            FileNameCB.CheckState = CheckState.Checked;
            FileNameCB.Location = new Point(266, 158);
            FileNameCB.Name = "FileNameCB";
            FileNameCB.Size = new Size(173, 29);
            FileNameCB.TabIndex = 8;
            FileNameCB.Text = "Search File Name";
            FileNameCB.UseVisualStyleBackColor = true;
            FileNameCB.CheckedChanged += OnCheckedChanged;
            // 
            // FileContentCB
            // 
            FileContentCB.AutoSize = true;
            FileContentCB.Location = new Point(266, 193);
            FileContentCB.Name = "FileContentCB";
            FileContentCB.Size = new Size(189, 29);
            FileContentCB.TabIndex = 9;
            FileContentCB.Text = "Search File Content";
            FileContentCB.UseVisualStyleBackColor = true;
            // 
            // ExtensionTooCB
            // 
            ExtensionTooCB.AutoSize = true;
            ExtensionTooCB.Location = new Point(460, 158);
            ExtensionTooCB.Name = "ExtensionTooCB";
            ExtensionTooCB.Size = new Size(203, 29);
            ExtensionTooCB.TabIndex = 11;
            ExtensionTooCB.Text = "Search Extension too";
            ExtensionTooCB.UseVisualStyleBackColor = true;
            // 
            // CurrentFileLabel
            // 
            CurrentFileLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CurrentFileLabel.AutoSize = true;
            CurrentFileLabel.Font = new Font("Segoe UI", 10F);
            CurrentFileLabel.ForeColor = Color.FromArgb(128, 128, 255);
            CurrentFileLabel.Location = new Point(200, 351);
            CurrentFileLabel.Name = "CurrentFileLabel";
            CurrentFileLabel.Size = new Size(0, 28);
            CurrentFileLabel.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2196, 472);
            Controls.Add(CurrentFileLabel);
            Controls.Add(NothingFoundLabel);
            Controls.Add(ExtensionTooCB);
            Controls.Add(FileContentCB);
            Controls.Add(FileNameCB);
            Controls.Add(QuitB);
            Controls.Add(SearchB);
            Controls.Add(FileListPanel);
            Controls.Add(TextToSearchTB);
            Controls.Add(label2);
            Controls.Add(DirectoryB);
            Controls.Add(DirectoryTB);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Search Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DirectoryTB;
        private Button DirectoryB;
        private Label label2;
        private TextBox TextToSearchTB;
        private Panel FileListPanel;
        private Button SearchB;
        private Button QuitB;
        private Label NothingFoundLabel;
        private CheckBox FileNameCB;
        private CheckBox FileContentCB;
        private CheckBox ExtensionTooCB;
        private Label CurrentFileLabel;
    }
}
