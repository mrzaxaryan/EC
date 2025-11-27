namespace EC.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            comboEncoding.Items.Add("ANSI → Unicode");
            comboEncoding.Items.Add("Unicode → ANSI");
            comboEncoding.SelectedIndex = 0;

            comboFont.Items.Add("Sylfaen");
            comboFont.Items.Add("Arial");
            comboFont.Items.Add("Calibri");
            comboFont.Items.Add("Times New Roman");
            comboFont.SelectedIndex = 0;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Word/Excel files|*.doc;*.docx;*.xls;*.xlsx|All files|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            MessageBox.Show("Conversion started!");
            LogInfo("Conversion started");
            LogOk("Everything good");
            LogWarn("This is a warning");
            LogError("Something bad happened");
        }

        private void Log(string prefix, string message)
        {
            string line = $"[{DateTime.Now:HH:mm:ss}] {prefix} {message}";
            richLog.AppendText(line + Environment.NewLine);
            richLog.SelectionStart = richLog.Text.Length;
            richLog.ScrollToCaret();
        }

        private void LogInfo(string msg) => Log("INFO", msg);
        private void LogOk(string msg) => Log(" OK ", msg);
        private void LogWarn(string msg) => Log("WARN", msg);
        private void LogError(string msg) => Log("ERR ", msg);
    }
}
