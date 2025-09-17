using System.Text;

namespace WindowSearch
{
    public partial class Form1 : Form
    {

        private List<string> fileContainingText = [];
        public Form1()
        {
            InitializeComponent();
            NothingFoundLabel.Visible = false;
        }

        private void DirectoryB_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (Directory.Exists(DirectoryTB.Text))
                dialog.InitialDirectory = DirectoryTB.Text;
            else
                dialog.InitialDirectory = Directory.GetCurrentDirectory();

            if (dialog.ShowDialog() == DialogResult.OK)
                DirectoryTB.Text = dialog.SelectedPath;
        }

        private async void SearchB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DirectoryTB.Text))
            {
                MessageBox.Show("Empty directory to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextToSearchTB.Text))
            {
                MessageBox.Show("Empty text to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(DirectoryTB.Text))
            {
                MessageBox.Show("Directory to search does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileListPanel.Controls.Clear();

            SetLabelText("Searching...", Color.LightSalmon);
            await SearchInDirectory();
        }

        private void OnLinkClicked(object? sender, EventArgs e)
        {
            LinkLabel link = (LinkLabel)(sender ?? new LinkLabel() { Text = "Error" });
            if (link.Text.Equals("Error"))
                return;
            link.LinkVisited = true;
            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", link.Text));
        }

        private async Task SearchInDirectory()
        {
            List<string> directoryToSearch = [DirectoryTB.Text];
            List<string> fileToSearch = [];
            fileContainingText = [];

            while (directoryToSearch.Count > 0)
            {
                fileToSearch.AddRange(Directory.GetFiles(directoryToSearch[0]));
                directoryToSearch.AddRange(Directory.GetDirectories(directoryToSearch[0]));
                directoryToSearch.RemoveAt(0);
            }

            if (FileNameCB.Checked)
            {
                foreach (string file in fileToSearch)
                {
                    string currentFileName = "";
                    if (ExtensionTooCB.Checked)
                        currentFileName = Path.GetFileName(file);
                    else
                        currentFileName = Path.GetFileNameWithoutExtension(file);

                    if (currentFileName.Contains(TextToSearchTB.Text))
                        fileContainingText.Add(file);
                }
            }

            if (FileContentCB.Checked)
            {
                foreach (string file in fileToSearch)
                {
                    if (await ReadFrom(file, TextToSearchTB.Text))
                    {
                        SetCurrentFileLabel(file);
                        fileContainingText.Add(file);
                    }
                }
            }

            if (fileContainingText.Count == 0)
            {
                SetLabelText("Nothing found!", Color.IndianRed, true);
            }
            else
            {
                SetLabelText("", Color.IndianRed, false);
                SetCurrentFileLabel("", false);
                for (int i = 0; i < fileContainingText.Count; i++)
                {
                    LinkLabel LinkToFileLabel = new()
                    {
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10F),
                        Location = new Point(15, 15 + 35 * i),
                        Name = "LinToFileLabel",
                        Text = fileContainingText[i]
                    };
                    LinkToFileLabel.Click += new EventHandler(OnLinkClicked);
                    FileListPanel.Controls.Add(LinkToFileLabel);
                }
            }
        }

        public void SetCurrentFileLabel(string text, bool visibility = true)
        {
            if (NothingFoundLabel.InvokeRequired)
            {
                CurrentFileLabel.BeginInvoke(new MethodInvoker(() => SetCurrentFileLabel(text)));
            }
            else
            {
                CurrentFileLabel.Text = text;
                CurrentFileLabel.Visible = visibility;
            }
        }

        public void SetLabelText(string text, Color color, bool visibility = true)
        {
            if (NothingFoundLabel.InvokeRequired)
            {
                NothingFoundLabel.BeginInvoke(new MethodInvoker(() => SetLabelText(text, color)));
            }
            else
            {
                NothingFoundLabel.Text = text;
                NothingFoundLabel.Visible = visibility;
                NothingFoundLabel.ForeColor = color;
            }
        }

        private async Task<bool> ReadFrom(string file, string TextToSearch)
        {
            const int MAX_BUFFER = 1048576; // 1MB
            byte[] buffer = new byte[MAX_BUFFER];

            using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read))
            using (BufferedStream bs = new BufferedStream(fs))
            {

                while (await bs.ReadAsync(buffer, 0, MAX_BUFFER) != 0)
                {
                    if (Encoding.UTF8.GetString(buffer).Contains(TextToSearch))
                        return true;
                }
                return false;
            }
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            ExtensionTooCB.Visible = FileNameCB.Checked;
        }

        private void QuitB_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
