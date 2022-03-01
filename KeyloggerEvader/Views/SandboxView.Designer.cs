namespace KeyloggerEvader.Views
{
    partial class SandBoxView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SandBoxView));
            this.DragDropCard = new MaterialSkin.Controls.MaterialCard();
            this.BrowseFileButton = new MaterialSkin.Controls.MaterialButton();
            this.DragDropLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.DragDropLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.UploadPictureBox = new System.Windows.Forms.PictureBox();
            this.SplitterPanel1 = new System.Windows.Forms.Panel();
            this.FilesListview = new MaterialSkin.Controls.MaterialListView();
            this.FileNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileExtensionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilePathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileStatusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilesListviewContextMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitterPanel2 = new System.Windows.Forms.Panel();
            this.RunButton = new MaterialSkin.Controls.MaterialButton();
            this.DragDropCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).BeginInit();
            this.FilesListviewContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragDropCard
            // 
            this.DragDropCard.AllowDrop = true;
            this.DragDropCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DragDropCard.Controls.Add(this.BrowseFileButton);
            this.DragDropCard.Controls.Add(this.DragDropLabel2);
            this.DragDropCard.Controls.Add(this.DragDropLabel1);
            this.DragDropCard.Controls.Add(this.UploadPictureBox);
            this.DragDropCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DragDropCard.Depth = 0;
            this.DragDropCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragDropCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DragDropCard.Location = new System.Drawing.Point(40, 40);
            this.DragDropCard.Margin = new System.Windows.Forms.Padding(0);
            this.DragDropCard.MaximumSize = new System.Drawing.Size(858, 300);
            this.DragDropCard.MinimumSize = new System.Drawing.Size(858, 300);
            this.DragDropCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.DragDropCard.Name = "DragDropCard";
            this.DragDropCard.Padding = new System.Windows.Forms.Padding(14);
            this.DragDropCard.Size = new System.Drawing.Size(858, 300);
            this.DragDropCard.TabIndex = 2;
            this.DragDropCard.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropCardDragDrop);
            this.DragDropCard.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragDropCardDragEnter);
            // 
            // BrowseFileButton
            // 
            this.BrowseFileButton.AutoSize = false;
            this.BrowseFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseFileButton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.BrowseFileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BrowseFileButton.Depth = 0;
            this.BrowseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BrowseFileButton.HighEmphasis = true;
            this.BrowseFileButton.Icon = ((System.Drawing.Image)(resources.GetObject("BrowseFileButton.Icon")));
            this.BrowseFileButton.Location = new System.Drawing.Point(354, 245);
            this.BrowseFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseFileButton.Name = "BrowseFileButton";
            this.BrowseFileButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BrowseFileButton.Size = new System.Drawing.Size(151, 45);
            this.BrowseFileButton.TabIndex = 3;
            this.BrowseFileButton.Text = "Browse for file";
            this.BrowseFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BrowseFileButton.UseAccentColor = false;
            this.BrowseFileButton.UseVisualStyleBackColor = false;
            this.BrowseFileButton.Click += new System.EventHandler(this.BrowseFileButtonClick);
            // 
            // DragDropLabel2
            // 
            this.DragDropLabel2.AutoSize = true;
            this.DragDropLabel2.Depth = 0;
            this.DragDropLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DragDropLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.DragDropLabel2.Location = new System.Drawing.Point(418, 192);
            this.DragDropLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.DragDropLabel2.Name = "DragDropLabel2";
            this.DragDropLabel2.Size = new System.Drawing.Size(23, 29);
            this.DragDropLabel2.TabIndex = 2;
            this.DragDropLabel2.Text = "or";
            // 
            // DragDropLabel1
            // 
            this.DragDropLabel1.AutoSize = true;
            this.DragDropLabel1.Depth = 0;
            this.DragDropLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DragDropLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.DragDropLabel1.Location = new System.Drawing.Point(294, 144);
            this.DragDropLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.DragDropLabel1.Name = "DragDropLabel1";
            this.DragDropLabel1.Size = new System.Drawing.Size(270, 29);
            this.DragDropLabel1.TabIndex = 1;
            this.DragDropLabel1.Text = "Drag And Drop Files Here";
            // 
            // UploadPictureBox
            // 
            this.UploadPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UploadPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UploadPictureBox.Image")));
            this.UploadPictureBox.Location = new System.Drawing.Point(354, 20);
            this.UploadPictureBox.Name = "UploadPictureBox";
            this.UploadPictureBox.Size = new System.Drawing.Size(150, 100);
            this.UploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UploadPictureBox.TabIndex = 0;
            this.UploadPictureBox.TabStop = false;
            // 
            // SplitterPanel1
            // 
            this.SplitterPanel1.BackColor = System.Drawing.Color.Transparent;
            this.SplitterPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel1.Location = new System.Drawing.Point(40, 340);
            this.SplitterPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.SplitterPanel1.MaximumSize = new System.Drawing.Size(858, 50);
            this.SplitterPanel1.MinimumSize = new System.Drawing.Size(858, 50);
            this.SplitterPanel1.Name = "SplitterPanel1";
            this.SplitterPanel1.Size = new System.Drawing.Size(858, 50);
            this.SplitterPanel1.TabIndex = 3;
            // 
            // FilesListview
            // 
            this.FilesListview.AllowColumnReorder = true;
            this.FilesListview.AutoSizeTable = false;
            this.FilesListview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FilesListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilesListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNameHeader,
            this.FileExtensionHeader,
            this.FilePathHeader,
            this.FileStatusHeader});
            this.FilesListview.ContextMenuStrip = this.FilesListviewContextMenu;
            this.FilesListview.Depth = 0;
            this.FilesListview.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilesListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.FilesListview.FullRowSelect = true;
            this.FilesListview.HideSelection = false;
            this.FilesListview.Location = new System.Drawing.Point(40, 390);
            this.FilesListview.Margin = new System.Windows.Forms.Padding(0);
            this.FilesListview.MaximumSize = new System.Drawing.Size(858, 300);
            this.FilesListview.MinimumSize = new System.Drawing.Size(858, 300);
            this.FilesListview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FilesListview.MouseState = MaterialSkin.MouseState.OUT;
            this.FilesListview.Name = "FilesListview";
            this.FilesListview.OwnerDraw = true;
            this.FilesListview.Size = new System.Drawing.Size(858, 300);
            this.FilesListview.TabIndex = 4;
            this.FilesListview.UseCompatibleStateImageBehavior = false;
            this.FilesListview.View = System.Windows.Forms.View.Details;
            // 
            // FileNameHeader
            // 
            this.FileNameHeader.Text = "Name";
            this.FileNameHeader.Width = 150;
            // 
            // FileExtensionHeader
            // 
            this.FileExtensionHeader.Text = "Extension";
            this.FileExtensionHeader.Width = 150;
            // 
            // FilePathHeader
            // 
            this.FilePathHeader.Text = "Path";
            this.FilePathHeader.Width = 100;
            // 
            // FileStatusHeader
            // 
            this.FileStatusHeader.Text = "Status";
            this.FileStatusHeader.Width = 100;
            // 
            // FilesListviewContextMenu
            // 
            this.FilesListviewContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FilesListviewContextMenu.Depth = 0;
            this.FilesListviewContextMenu.DropShadowEnabled = false;
            this.FilesListviewContextMenu.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.FilesListviewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.runToolStripMenuItem});
            this.FilesListviewContextMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.FilesListviewContextMenu.Name = "FilesListviewContextMenu";
            this.FilesListviewContextMenu.Size = new System.Drawing.Size(177, 112);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItemClick);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItemClick);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.RunToolStripMenuItemClick);
            // 
            // SplitterPanel2
            // 
            this.SplitterPanel2.BackColor = System.Drawing.Color.Transparent;
            this.SplitterPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel2.Location = new System.Drawing.Point(40, 690);
            this.SplitterPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.SplitterPanel2.MaximumSize = new System.Drawing.Size(858, 50);
            this.SplitterPanel2.MinimumSize = new System.Drawing.Size(858, 50);
            this.SplitterPanel2.Name = "SplitterPanel2";
            this.SplitterPanel2.Size = new System.Drawing.Size(858, 50);
            this.SplitterPanel2.TabIndex = 5;
            // 
            // RunButton
            // 
            this.RunButton.AutoSize = false;
            this.RunButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RunButton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.RunButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RunButton.Depth = 0;
            this.RunButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RunButton.HighEmphasis = true;
            this.RunButton.Icon = ((System.Drawing.Image)(resources.GetObject("RunButton.Icon")));
            this.RunButton.Location = new System.Drawing.Point(40, 740);
            this.RunButton.Margin = new System.Windows.Forms.Padding(0);
            this.RunButton.MaximumSize = new System.Drawing.Size(130, 45);
            this.RunButton.MinimumSize = new System.Drawing.Size(130, 45);
            this.RunButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RunButton.Name = "RunButton";
            this.RunButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RunButton.Size = new System.Drawing.Size(130, 45);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Run files";
            this.RunButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RunButton.UseAccentColor = false;
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButtonClick);
            // 
            // SandBoxView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.SplitterPanel2);
            this.Controls.Add(this.FilesListview);
            this.Controls.Add(this.SplitterPanel1);
            this.Controls.Add(this.DragDropCard);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SandBoxView";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(938, 825);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.DragDropCard.ResumeLayout(false);
            this.DragDropCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).EndInit();
            this.FilesListviewContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard DragDropCard;
        public MaterialSkin.Controls.MaterialButton BrowseFileButton;
        private MaterialSkin.Controls.MaterialLabel DragDropLabel2;
        private MaterialSkin.Controls.MaterialLabel DragDropLabel1;
        private System.Windows.Forms.PictureBox UploadPictureBox;
        private System.Windows.Forms.Panel SplitterPanel1;
        private System.Windows.Forms.ColumnHeader FileNameHeader;
        private System.Windows.Forms.ColumnHeader FileExtensionHeader;
        private System.Windows.Forms.ColumnHeader FilePathHeader;
        private System.Windows.Forms.ColumnHeader FileStatusHeader;
        public MaterialSkin.Controls.MaterialListView FilesListview;
        private System.Windows.Forms.Panel SplitterPanel2;
        public MaterialSkin.Controls.MaterialButton RunButton;
        private MaterialSkin.Controls.MaterialContextMenuStrip FilesListviewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
    }
}
