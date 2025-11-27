namespace EC.GUI
{
    partial class MainForm
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
            panelFile = new Panel();
            lblFileTitle = new Label();
            btnBrowseFolder = new Button();
            btnBrowseFile = new Button();
            txtPath = new TextBox();
            lblPath = new Label();
            panelSettings = new Panel();
            btnTheme = new Button();
            comboFont = new ComboBox();
            lblFont = new Label();
            comboEncoding = new ComboBox();
            lblEncoding = new Label();
            lblSettingsTitle = new Label();
            panelActions = new Panel();
            progressBar = new ProgressBar();
            btnConvert = new Button();
            lblActions = new Label();
            panelLog = new Panel();
            richLog = new RichTextBox();
            lblLog = new Label();
            panelFile.SuspendLayout();
            panelSettings.SuspendLayout();
            panelActions.SuspendLayout();
            panelLog.SuspendLayout();
            SuspendLayout();
            // 
            // panelFile
            // 
            panelFile.Controls.Add(lblFileTitle);
            panelFile.Controls.Add(btnBrowseFolder);
            panelFile.Controls.Add(btnBrowseFile);
            panelFile.Controls.Add(txtPath);
            panelFile.Controls.Add(lblPath);
            panelFile.Dock = DockStyle.Top;
            panelFile.Location = new Point(0, 0);
            panelFile.Name = "panelFile";
            panelFile.Size = new Size(812, 75);
            panelFile.TabIndex = 0;
            // 
            // lblFileTitle
            // 
            lblFileTitle.AutoSize = true;
            lblFileTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileTitle.Location = new Point(10, 8);
            lblFileTitle.Name = "lblFileTitle";
            lblFileTitle.Size = new Size(72, 15);
            lblFileTitle.TabIndex = 5;
            lblFileTitle.Text = "File / Folder";
            // 
            // btnBrowseFolder
            // 
            btnBrowseFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseFolder.Location = new Point(740, 25);
            btnBrowseFolder.Name = "btnBrowseFolder";
            btnBrowseFolder.Size = new Size(60, 25);
            btnBrowseFolder.TabIndex = 3;
            btnBrowseFolder.Text = "Folder";
            btnBrowseFolder.UseVisualStyleBackColor = true;
            btnBrowseFolder.Click += btnBrowseFolder_Click;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseFile.Location = new Point(674, 25);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(60, 25);
            btnBrowseFile.TabIndex = 2;
            btnBrowseFile.Text = "File";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // txtPath
            // 
            txtPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPath.Location = new Point(60, 27);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(608, 23);
            txtPath.TabIndex = 1;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(10, 30);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(31, 15);
            lblPath.TabIndex = 0;
            lblPath.Text = "Path";
            // 
            // panelSettings
            // 
            panelSettings.Controls.Add(btnTheme);
            panelSettings.Controls.Add(comboFont);
            panelSettings.Controls.Add(lblFont);
            panelSettings.Controls.Add(comboEncoding);
            panelSettings.Controls.Add(lblEncoding);
            panelSettings.Controls.Add(lblSettingsTitle);
            panelSettings.Location = new Point(0, 81);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(812, 89);
            panelSettings.TabIndex = 1;
            // 
            // btnTheme
            // 
            btnTheme.Anchor = AnchorStyles.Right;
            btnTheme.Location = new Point(674, 32);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(126, 25);
            btnTheme.TabIndex = 5;
            btnTheme.Text = "Theme";
            btnTheme.UseVisualStyleBackColor = true;
            // 
            // comboFont
            // 
            comboFont.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFont.FormattingEnabled = true;
            comboFont.Location = new Point(340, 32);
            comboFont.Name = "comboFont";
            comboFont.Size = new Size(180, 23);
            comboFont.TabIndex = 4;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(300, 35);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(31, 15);
            lblFont.TabIndex = 3;
            lblFont.Text = "Font";
            // 
            // comboEncoding
            // 
            comboEncoding.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEncoding.FormattingEnabled = true;
            comboEncoding.Location = new Point(91, 32);
            comboEncoding.Name = "comboEncoding";
            comboEncoding.Size = new Size(189, 23);
            comboEncoding.TabIndex = 2;
            // 
            // lblEncoding
            // 
            lblEncoding.AutoSize = true;
            lblEncoding.Location = new Point(10, 35);
            lblEncoding.Name = "lblEncoding";
            lblEncoding.Size = new Size(57, 15);
            lblEncoding.TabIndex = 1;
            lblEncoding.Text = "Encoding";
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.AutoSize = true;
            lblSettingsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSettingsTitle.Location = new Point(10, 8);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new Size(53, 15);
            lblSettingsTitle.TabIndex = 0;
            lblSettingsTitle.Text = "Settings";
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelActions.Controls.Add(progressBar);
            panelActions.Controls.Add(btnConvert);
            panelActions.Controls.Add(lblActions);
            panelActions.Location = new Point(0, 176);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(812, 75);
            panelActions.TabIndex = 2;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(91, 35);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(709, 23);
            progressBar.TabIndex = 2;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(10, 35);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblActions
            // 
            lblActions.AutoSize = true;
            lblActions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActions.Location = new Point(10, 8);
            lblActions.Name = "lblActions";
            lblActions.Size = new Size(48, 15);
            lblActions.TabIndex = 0;
            lblActions.Text = "Actions";
            // 
            // panelLog
            // 
            panelLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLog.Controls.Add(richLog);
            panelLog.Controls.Add(lblLog);
            panelLog.Location = new Point(0, 257);
            panelLog.Name = "panelLog";
            panelLog.Size = new Size(812, 194);
            panelLog.TabIndex = 3;
            // 
            // richLog
            // 
            richLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richLog.Location = new Point(10, 30);
            richLog.Name = "richLog";
            richLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            richLog.Size = new Size(790, 151);
            richLog.TabIndex = 1;
            richLog.Text = "";
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLog.Location = new Point(10, 8);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(27, 15);
            lblLog.TabIndex = 0;
            lblLog.Text = "Log";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 450);
            Controls.Add(panelLog);
            Controls.Add(panelActions);
            Controls.Add(panelSettings);
            Controls.Add(panelFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encoding Converter GUI";
            panelFile.ResumeLayout(false);
            panelFile.PerformLayout();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            panelLog.ResumeLayout(false);
            panelLog.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFile;
        private Label lblPath;
        private TextBox txtPath;
        private Button btnBrowseFile;
        private Button btnBrowseFolder;
        private Label lblFileTitle;
        private Panel panelSettings;
        private ComboBox comboEncoding;
        private Label lblEncoding;
        private Label lblSettingsTitle;
        private Button btnTheme;
        private ComboBox comboFont;
        private Label lblFont;
        private Panel panelActions;
        private Button btnConvert;
        private Label lblActions;
        private ProgressBar progressBar;
        private Panel panelLog;
        private RichTextBox richLog;
        private Label lblLog;
    }
}