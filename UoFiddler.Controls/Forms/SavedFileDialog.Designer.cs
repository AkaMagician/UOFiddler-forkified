namespace UoFiddler.Controls.Forms
{
    partial class SavedFileDialog
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
            if (disposing)
            {
                informationPictureBox.Image?.Dispose();
                components?.Dispose();
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
            this.rootLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.informationPictureBox = new System.Windows.Forms.PictureBox();
            this.contentLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.buttonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.rootLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationPictureBox)).BeginInit();
            this.contentLayoutPanel.SuspendLayout();
            this.buttonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLayoutPanel
            // 
            this.rootLayoutPanel.AutoSize = true;
            this.rootLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rootLayoutPanel.ColumnCount = 2;
            this.rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayoutPanel.Controls.Add(this.informationPictureBox, 0, 0);
            this.rootLayoutPanel.Controls.Add(this.contentLayoutPanel, 1, 0);
            this.rootLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.rootLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rootLayoutPanel.Name = "rootLayoutPanel";
            this.rootLayoutPanel.RowCount = 1;
            this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayoutPanel.Size = new System.Drawing.Size(528, 152);
            this.rootLayoutPanel.TabIndex = 0;
            // 
            // informationPictureBox
            // 
            this.informationPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.informationPictureBox.Location = new System.Drawing.Point(10, 6);
            this.informationPictureBox.Margin = new System.Windows.Forms.Padding(10, 6, 10, 0);
            this.informationPictureBox.Name = "informationPictureBox";
            this.informationPictureBox.Size = new System.Drawing.Size(32, 32);
            this.informationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.informationPictureBox.TabIndex = 0;
            this.informationPictureBox.TabStop = false;
            // 
            // contentLayoutPanel
            // 
            this.contentLayoutPanel.AutoSize = true;
            this.contentLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentLayoutPanel.ColumnCount = 1;
            this.contentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentLayoutPanel.Controls.Add(this.messageLabel, 0, 0);
            this.contentLayoutPanel.Controls.Add(this.pathLabel, 0, 1);
            this.contentLayoutPanel.Controls.Add(this.buttonLayoutPanel, 0, 2);
            this.contentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayoutPanel.Location = new System.Drawing.Point(52, 0);
            this.contentLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentLayoutPanel.Name = "contentLayoutPanel";
            this.contentLayoutPanel.RowCount = 3;
            this.contentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayoutPanel.Size = new System.Drawing.Size(476, 152);
            this.contentLayoutPanel.TabIndex = 1;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.Location = new System.Drawing.Point(0, 0);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 8);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(476, 15);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Saved successfully.";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathLabel.Location = new System.Drawing.Point(0, 23);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.pathLabel.MaximumSize = new System.Drawing.Size(470, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(470, 75);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "C:\\Path\\To\\Saved\\File.ext";
            this.pathLabel.UseMnemonic = false;
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLayoutPanel.AutoSize = true;
            this.buttonLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLayoutPanel.ColumnCount = 2;
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.buttonLayoutPanel.Controls.Add(this.openFolderButton, 0, 0);
            this.buttonLayoutPanel.Controls.Add(this.okButton, 1, 0);
            this.buttonLayoutPanel.Location = new System.Drawing.Point(236, 114);
            this.buttonLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.RowCount = 1;
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.buttonLayoutPanel.Size = new System.Drawing.Size(240, 32);
            this.buttonLayoutPanel.TabIndex = 2;
            // 
            // openFolderButton
            // 
            this.openFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openFolderButton.Location = new System.Drawing.Point(0, 0);
            this.openFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(120, 32);
            this.openFolderButton.TabIndex = 0;
            this.openFolderButton.Text = "Open Folder";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.OnOpenFolderClick);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(120, 0);
            this.okButton.Margin = new System.Windows.Forms.Padding(0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(120, 32);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // SavedFileDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(552, 176);
            this.Controls.Add(this.rootLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SavedFileDialog";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saved";
            this.rootLayoutPanel.ResumeLayout(false);
            this.rootLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationPictureBox)).EndInit();
            this.contentLayoutPanel.ResumeLayout(false);
            this.contentLayoutPanel.PerformLayout();
            this.buttonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootLayoutPanel;
        private System.Windows.Forms.PictureBox informationPictureBox;
        private System.Windows.Forms.TableLayoutPanel contentLayoutPanel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TableLayoutPanel buttonLayoutPanel;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.Button okButton;
    }
}
