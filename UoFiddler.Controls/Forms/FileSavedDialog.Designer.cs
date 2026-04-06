namespace UoFiddler.Controls.Forms
{
    partial class FileSavedDialog
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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.contentLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.contentLayoutPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoSize = true;
            this.mainLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.iconPictureBox, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.contentLayoutPanel, 1, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(560, 86);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            // 
            // contentLayoutPanel
            // 
            this.contentLayoutPanel.AutoSize = true;
            this.contentLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentLayoutPanel.ColumnCount = 1;
            this.contentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentLayoutPanel.Controls.Add(this.statusLabel, 0, 0);
            this.contentLayoutPanel.Controls.Add(this.pathLabel, 0, 1);
            this.contentLayoutPanel.Controls.Add(this.buttonsPanel, 0, 2);
            this.contentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayoutPanel.Location = new System.Drawing.Point(44, 0);
            this.contentLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentLayoutPanel.Name = "contentLayoutPanel";
            this.contentLayoutPanel.RowCount = 3;
            this.contentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayoutPanel.Size = new System.Drawing.Size(516, 86);
            this.contentLayoutPanel.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(130, 15);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "File saved successfully.";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(0, 21);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pathLabel.MaximumSize = new System.Drawing.Size(516, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(148, 15);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "C:\\Path\\To\\Saved\\File.ext";
            this.pathLabel.UseMnemonic = false;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.ColumnCount = 2;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.buttonsPanel.Controls.Add(this.buttonOpenFolder, 0, 0);
            this.buttonsPanel.Controls.Add(this.buttonOk, 1, 0);
            this.buttonsPanel.Location = new System.Drawing.Point(260, 48);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 1;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.buttonsPanel.Size = new System.Drawing.Size(256, 36);
            this.buttonsPanel.TabIndex = 2;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenFolder.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(120, 32);
            this.buttonOpenFolder.TabIndex = 0;
            this.buttonOpenFolder.Text = "Open Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.OnOpenFolderClick);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(128, 0);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(120, 32);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // FileSavedDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonOk;
            this.ClientSize = new System.Drawing.Size(584, 110);
            this.Controls.Add(this.mainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileSavedDialog";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saved";
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.contentLayoutPanel.ResumeLayout(false);
            this.contentLayoutPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.TableLayoutPanel contentLayoutPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Button buttonOk;
    }
}
