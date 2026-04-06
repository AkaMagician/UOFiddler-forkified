using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UoFiddler.Controls.Forms
{
    public sealed partial class FileSavedDialog : Form
    {
        private readonly string _filePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSavedDialog"/> class.
        /// </summary>
        public FileSavedDialog(string filePath, string message = null, string title = null)
        {
            InitializeComponent();

            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
            statusLabel.Text = message ?? "File saved successfully.";
            pathLabel.Text = _filePath;

            if (!string.IsNullOrWhiteSpace(title))
            {
                Text = title;
            }

            iconPictureBox.Image = SystemIcons.Information.ToBitmap();
        }

        /// <summary>
        /// Shows the dialog with the specified owner.
        /// </summary>
        public static void Show(IWin32Window owner, string filePath, string message = null, string title = null)
        {
            using (var dialog = new FileSavedDialog(filePath, message, title))
            {
                dialog.ShowDialog(owner);
            }
        }

        /// <summary>
        /// Shows the dialog without specifying an owner.
        /// </summary>
        public static void Show(string filePath, string message = null, string title = null)
        {
            using (var dialog = new FileSavedDialog(filePath, message, title))
            {
                dialog.ShowDialog();
            }
        }

        private void OnOpenFolderClick(object sender, EventArgs e)
        {
            try
            {
                string folderPath = Path.GetDirectoryName(_filePath);
                if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = folderPath,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Unable to open folder: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
