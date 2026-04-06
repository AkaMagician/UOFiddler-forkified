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
    public partial class SavedFileDialog : Form
    {
        private readonly string _folderPath;

        public SavedFileDialog(string dialogTitle, string statusMessage, string filePath)
        {
            InitializeComponent();

            Text = dialogTitle ?? string.Empty;
            messageLabel.Text = statusMessage ?? string.Empty;
            pathLabel.Text = filePath ?? string.Empty;

            _folderPath = Path.GetDirectoryName(filePath ?? string.Empty);
            openFolderButton.Enabled = !string.IsNullOrEmpty(_folderPath) && Directory.Exists(_folderPath);

            informationPictureBox.Image = SystemIcons.Information.ToBitmap();
            Font = SystemFonts.MessageBoxFont;

            AcceptButton = okButton;
            CancelButton = okButton;
            ActiveControl = okButton;
        }

        private void OnOpenFolderClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_folderPath) && Directory.Exists(_folderPath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = _folderPath,
                    UseShellExecute = true
                });
            }
        }
    }
}
