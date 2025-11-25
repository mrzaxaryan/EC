namespace EC.GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelFile;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelLog;

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnBrowseFolder;

        private System.Windows.Forms.ComboBox comboEncoding;
        private System.Windows.Forms.ComboBox comboFont;

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RichTextBox richLog;
        private System.Windows.Forms.ProgressBar progressBar;

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblLogTitle;
        private System.Windows.Forms.Label lblActionsTitle;
        private System.Windows.Forms.Label lblSettingsTitle;
        private System.Windows.Forms.Label lblFileTitle;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelFile = new System.Windows.Forms.Panel();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.lblFileTitle = new System.Windows.Forms.Label();

            this.panelSettings = new System.Windows.Forms.Panel();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.comboEncoding = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.comboFont = new System.Windows.Forms.ComboBox();
            this.lblSettingsTitle = new System.Windows.Forms.Label();

            this.panelActions = new System.Windows.Forms.Panel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblActionsTitle = new System.Windows.Forms.Label();

            this.panelLog = new System.Windows.Forms.Panel();
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.lblLogTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // === Общие настройки формы ===
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.Text = "Encoding Converter GUI";

            // тёмно-фиолетовая тема
            this.BackColor = System.Drawing.Color.FromArgb(32, 32, 48);
            this.ForeColor = System.Drawing.Color.Gainsboro;

            // === panelFile ===
            this.panelFile.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.panelFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFile.Location = new System.Drawing.Point(12, 12);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(876, 90);
            this.panelFile.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                     | System.Windows.Forms.AnchorStyles.Left
                                     | System.Windows.Forms.AnchorStyles.Right);

            // lblFileTitle
            this.lblFileTitle.AutoSize = true;
            this.lblFileTitle.Location = new System.Drawing.Point(10, 8);
            this.lblFileTitle.Name = "lblFileTitle";
            this.lblFileTitle.Size = new System.Drawing.Size(64, 15);
            this.lblFileTitle.Text = "File / Folder";

            // lblPath
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(10, 32);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 15);
            this.lblPath.Text = "Path";

            // txtPath
            this.txtPath.Location = new System.Drawing.Point(60, 29);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(620, 23);
            this.txtPath.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                   | System.Windows.Forms.AnchorStyles.Left
                                   | System.Windows.Forms.AnchorStyles.Right);

            // btnBrowseFile
            this.btnBrowseFile.Location = new System.Drawing.Point(690, 28);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(80, 25);
            this.btnBrowseFile.Text = "File...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            this.btnBrowseFile.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                         | System.Windows.Forms.AnchorStyles.Right);

            // btnBrowseFolder
            this.btnBrowseFolder.Location = new System.Drawing.Point(780, 28);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(80, 25);
            this.btnBrowseFolder.Text = "Folder...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            this.btnBrowseFolder.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                           | System.Windows.Forms.AnchorStyles.Right);

            this.panelFile.Controls.Add(this.lblFileTitle);
            this.panelFile.Controls.Add(this.lblPath);
            this.panelFile.Controls.Add(this.txtPath);
            this.panelFile.Controls.Add(this.btnBrowseFile);
            this.panelFile.Controls.Add(this.btnBrowseFolder);

            // === panelSettings ===
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Location = new System.Drawing.Point(12, 110);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(876, 80);
            this.panelSettings.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                         | System.Windows.Forms.AnchorStyles.Left
                                         | System.Windows.Forms.AnchorStyles.Right);

            // lblSettingsTitle
            this.lblSettingsTitle.AutoSize = true;
            this.lblSettingsTitle.Location = new System.Drawing.Point(10, 8);
            this.lblSettingsTitle.Name = "lblSettingsTitle";
            this.lblSettingsTitle.Size = new System.Drawing.Size(51, 15);
            this.lblSettingsTitle.Text = "Settings";

            // lblEncoding
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(10, 35);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(58, 15);
            this.lblEncoding.Text = "Encoding";

            // comboEncoding
            this.comboEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEncoding.Location = new System.Drawing.Point(80, 32);
            this.comboEncoding.Name = "comboEncoding";
            this.comboEncoding.Size = new System.Drawing.Size(200, 23);
            this.comboEncoding.Items.AddRange(new object[]
            {
                "ANSI → Unicode",
                "Unicode → ANSI"
            });

            // lblFont
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(310, 35);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(31, 15);
            this.lblFont.Text = "Font";

            // comboFont
            this.comboFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFont.Location = new System.Drawing.Point(350, 32);
            this.comboFont.Name = "comboFont";
            this.comboFont.Size = new System.Drawing.Size(200, 23);
            this.comboFont.Items.AddRange(new object[]
            {
                "Sylfaen",
                "Arial",
                "Calibri",
                "Times New Roman"
            });

            this.panelSettings.Controls.Add(this.lblSettingsTitle);
            this.panelSettings.Controls.Add(this.lblEncoding);
            this.panelSettings.Controls.Add(this.comboEncoding);
            this.panelSettings.Controls.Add(this.lblFont);
            this.panelSettings.Controls.Add(this.comboFont);

            // === panelActions ===
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.panelActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActions.Location = new System.Drawing.Point(12, 198);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(876, 80);
            this.panelActions.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                         | System.Windows.Forms.AnchorStyles.Left
                                         | System.Windows.Forms.AnchorStyles.Right);

            // lblActionsTitle
            this.lblActionsTitle.AutoSize = true;
            this.lblActionsTitle.Location = new System.Drawing.Point(10, 8);
            this.lblActionsTitle.Name = "lblActionsTitle";
            this.lblActionsTitle.Size = new System.Drawing.Size(48, 15);
            this.lblActionsTitle.Text = "Actions";

            // btnConvert
            this.btnConvert.Location = new System.Drawing.Point(10, 34);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(120, 30);
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);

            // progressBar
            this.progressBar.Location = new System.Drawing.Point(150, 39);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(710, 20);
            this.progressBar.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                       | System.Windows.Forms.AnchorStyles.Left
                                       | System.Windows.Forms.AnchorStyles.Right);

            this.panelActions.Controls.Add(this.lblActionsTitle);
            this.panelActions.Controls.Add(this.btnConvert);
            this.panelActions.Controls.Add(this.progressBar);

            // === panelLog ===
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.panelLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLog.Location = new System.Drawing.Point(12, 286);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(876, 302);
            this.panelLog.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                     | System.Windows.Forms.AnchorStyles.Bottom
                                     | System.Windows.Forms.AnchorStyles.Left
                                     | System.Windows.Forms.AnchorStyles.Right);

            // lblLogTitle
            this.lblLogTitle.AutoSize = true;
            this.lblLogTitle.Location = new System.Drawing.Point(10, 8);
            this.lblLogTitle.Name = "lblLogTitle";
            this.lblLogTitle.Size = new System.Drawing.Size(28, 15);
            this.lblLogTitle.Text = "Log";

            // richLog
            this.richLog.Location = new System.Drawing.Point(10, 28);
            this.richLog.Name = "richLog";
            this.richLog.Size = new System.Drawing.Size(856, 262);
            this.richLog.ReadOnly = true;
            this.richLog.BackColor = System.Drawing.Color.FromArgb(24, 24, 36);
            this.richLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.richLog.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                   | System.Windows.Forms.AnchorStyles.Bottom
                                   | System.Windows.Forms.AnchorStyles.Left
                                   | System.Windows.Forms.AnchorStyles.Right);

            this.panelLog.Controls.Add(this.lblLogTitle);
            this.panelLog.Controls.Add(this.richLog);

            // === Добавляем панели на форму ===
            this.Controls.Add(this.panelFile);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelLog);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
