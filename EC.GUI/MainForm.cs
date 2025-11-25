using EC.Library.Converters;
using EC.Library.Core;

namespace EC.GUI
{
    public partial class MainForm : Form
    {
        private static readonly string[] WordExtensions = { ".doc", ".docx" };
        private static readonly string[] ExcelExtensions = { ".xls", ".xlsx" };
        private static readonly string[] SupportedExtensions =
            WordExtensions.Concat(ExcelExtensions).ToArray();

        public MainForm()
        {
            InitializeComponent();
            InitializeCustom();
        }

        private void InitializeCustom()
        {
            // ????????? ????????
            comboEncoding.SelectedIndex = 0;
            comboFont.SelectedIndex = 0;

            // Drag & Drop
            AllowDrop = true;
            txtPath.AllowDrop = true;

            DragEnter += MainForm_DragEnter;
            DragDrop += MainForm_DragDrop;
            txtPath.DragEnter += MainForm_DragEnter;
            txtPath.DragDrop += MainForm_DragDrop;
        }

        // ==== Drag & Drop ====

        private void MainForm_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainForm_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetData(DataFormats.FileDrop) is string[] paths && paths.Length > 0)
            {
                txtPath.Text = paths[0];
                LogInfo($"Path set from drag & drop: {paths[0]}");
            }
        }

        // ==== ?????? ?????? ???? ====

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Word/Excel files|*.doc;*.docx;*.xls;*.xlsx";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;
                LogInfo($"File selected: {dlg.FileName}");
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
                LogInfo($"Folder selected: {dlg.SelectedPath}");
            }
        }

        // ==== ??????????? ====

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text.Trim();

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show(this, "Please select file or folder.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(path) && !Directory.Exists(path))
            {
                MessageBox.Show(this, "Specified path does not exist.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnConvert.Enabled = false;
            progressBar.Value = 0;
            LogInfo("Starting conversion...");

            try
            {
                string baseDir = AppContext.BaseDirectory;
                string mapPath = Path.Combine(baseDir, "Encodings", "armenian.map");

                var mapper = EncodingMapper.FromFile(mapPath);
                var textConverter = new TextConverter(mapper);
                using var word = new WordConverter(textConverter, false);
                using var excel = new ExcelConverter(textConverter, false);

                var encodingType = comboEncoding.SelectedIndex == 0
                    ? EncodingType.ANSIToUnicode
                    : EncodingType.UnicodeToANSI;

                string fontName = comboFont.SelectedItem?.ToString() ?? "Sylfaen";

                if (File.Exists(path))
                {
                    // ????????? ????
                    await Task.Run(() =>
                        ConvertFile(path, encodingType, fontName, word, excel));
                    progressBar.Value = progressBar.Maximum;
                }
                else
                {
                    // ?????
                    var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                        .Where(f => SupportedExtensions.Contains(
                            Path.GetExtension(f),
                            StringComparer.OrdinalIgnoreCase))
                        .ToArray();

                    if (files.Length == 0)
                    {
                        LogWarn("No supported files found in folder.");
                    }
                    else
                    {
                        progressBar.Minimum = 0;
                        progressBar.Maximum = files.Length;
                        progressBar.Value = 0;

                        int processed = 0;

                        await Task.Run(() =>
                        {
                            foreach (var file in files)
                            {
                                try
                                {
                                    ConvertFile(file, encodingType, fontName, word, excel);
                                    processed++;

                                    Invoke(new Action(() =>
                                    {
                                        if (processed <= progressBar.Maximum)
                                            progressBar.Value = processed;
                                    }));
                                }
                                catch (Exception exFile)
                                {
                                    Invoke(new Action(() =>
                                    {
                                        LogError($"[FILE ERROR] {file}: {exFile.Message}");
                                    }));
                                }
                            }
                        });

                        LogInfo($"Processed {processed} file(s).");
                    }
                }

                LogOk("Conversion finished.");
            }
            catch (Exception ex)
            {
                LogError("Error: " + ex.Message);
            }
            finally
            {
                btnConvert.Enabled = true;
            }
        }

        private void ConvertFile(
            string file,
            EncodingType encodingType,
            string fontName,
            WordConverter word,
            ExcelConverter excel)
        {
            string ext = Path.GetExtension(file);

            if (WordExtensions.Contains(ext, StringComparer.OrdinalIgnoreCase))
            {
                LogInfo($"[WORD] Converting: {file}");
                word.Convert(file, encodingType, fontName);
                LogOk($"[WORD] Done: {file}");
            }
            else if (ExcelExtensions.Contains(ext, StringComparer.OrdinalIgnoreCase))
            {
                LogInfo($"[EXCEL] Converting: {file}");
                excel.Convert(file, encodingType, fontName);
                LogOk($"[EXCEL] Done: {file}");
            }
            else
            {
                LogWarn($"[SKIP] Unsupported extension: {file}");
            }
        }

        // ==== ??????????? ? ??????? ????? ====

        private void Log(string prefix, string message)
        {
            string line = $"[{DateTime.Now:HH:mm:ss}] {prefix} {message}";
            richLog.AppendText(line + Environment.NewLine);
        }

        private void LogInfo(string msg) => Log("INFO", msg);
        private void LogOk(string msg) => Log(" OK ", msg);
        private void LogWarn(string msg) => Log("WARN", msg);
        private void LogError(string msg) => Log("ERR ", msg);
    }
}