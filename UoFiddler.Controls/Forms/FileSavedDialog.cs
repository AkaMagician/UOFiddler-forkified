/***************************************************************************
 *
 * $Author: Turley
 *
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

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

        public FileSavedDialog(string filePath, string message = null, string title = null)
        {
            InitializeComponent();

            _filePath = filePath ?? string.Empty;
            statusLabel.Text = string.IsNullOrWhiteSpace(message) ? "File saved successfully." : message;
            pathLabel.Text = _filePath;
            Text = string.IsNullOrWhiteSpace(title) ? "Saved" : title;

            iconPictureBox.Image = SystemIcons.Information.ToBitmap();
        }

        public static void Show(IWin32Window owner, string filePath, string message = null, string title = null)
        {
            using (var dialog = new FileSavedDialog(filePath, message, title))
            {
                if (owner != null)
                {
                    dialog.ShowDialog(owner);
                }
                else
                {
                    dialog.ShowDialog();
                }
            }
        }

        public static void Show(string filePath, string message = null, string title = null)
        {
            Show(null, filePath, message, title);
        }

        private void OnOpenFolderClick(object sender, EventArgs e)
        {
            try
            {
                string folderPath = Path.GetDirectoryName(_filePath);
                if (!string.IsNullOrEmpty(folderPath))
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
                MessageBox.Show(this, $"Failed to open folder.\n{ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
