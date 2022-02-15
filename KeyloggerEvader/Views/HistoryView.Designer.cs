namespace KeyloggerEvader.Views
{
    partial class HistoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryView));
            this.HistoryListview = new MaterialSkin.Controls.MaterialListView();
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeStampColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HistoryContextMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.DeleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ExportButton = new MaterialSkin.Controls.MaterialButton();
            this.ClearButton = new MaterialSkin.Controls.MaterialButton();
            this.Splitter = new MaterialSkin.Controls.MaterialDivider();
            this.HistoryContextMenu.SuspendLayout();
            this.HistoryTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryListview
            // 
            this.HistoryListview.AllowColumnReorder = true;
            this.HistoryListview.AutoSizeTable = false;
            this.HistoryListview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HistoryListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader,
            this.TimeStampColumnHeader,
            this.DurationColumnHeader,
            this.StatusColumnHeader});
            this.HistoryTableLayout.SetColumnSpan(this.HistoryListview, 4);
            this.HistoryListview.ContextMenuStrip = this.HistoryContextMenu;
            this.HistoryListview.Depth = 0;
            this.HistoryListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.HistoryListview.FullRowSelect = true;
            this.HistoryListview.HideSelection = false;
            this.HistoryListview.Location = new System.Drawing.Point(3, 73);
            this.HistoryListview.MaximumSize = new System.Drawing.Size(852, 707);
            this.HistoryListview.MinimumSize = new System.Drawing.Size(852, 707);
            this.HistoryListview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.HistoryListview.MouseState = MaterialSkin.MouseState.OUT;
            this.HistoryListview.Name = "HistoryListview";
            this.HistoryListview.OwnerDraw = true;
            this.HistoryListview.Size = new System.Drawing.Size(852, 707);
            this.HistoryListview.TabIndex = 0;
            this.HistoryListview.UseCompatibleStateImageBehavior = false;
            this.HistoryListview.View = System.Windows.Forms.View.Details;
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Text = "Name";
            this.NameColumnHeader.Width = 100;
            // 
            // TimeStampColumnHeader
            // 
            this.TimeStampColumnHeader.Text = "TimeStamp";
            this.TimeStampColumnHeader.Width = 150;
            // 
            // DurationColumnHeader
            // 
            this.DurationColumnHeader.Text = "Duration";
            this.DurationColumnHeader.Width = 100;
            // 
            // StatusColumnHeader
            // 
            this.StatusColumnHeader.Text = "Status";
            this.StatusColumnHeader.Width = 100;
            // 
            // HistoryContextMenu
            // 
            this.HistoryContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HistoryContextMenu.Depth = 0;
            this.HistoryContextMenu.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.HistoryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteRecordToolStripMenuItem});
            this.HistoryContextMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.HistoryContextMenu.Name = "HistoryContextMenu";
            this.HistoryContextMenu.ShowImageMargin = false;
            this.HistoryContextMenu.Size = new System.Drawing.Size(214, 40);
            // 
            // DeleteRecordToolStripMenuItem
            // 
            this.DeleteRecordToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteRecordToolStripMenuItem.Name = "DeleteRecordToolStripMenuItem";
            this.DeleteRecordToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 1, 0, 1);
            this.DeleteRecordToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.DeleteRecordToolStripMenuItem.Text = "Delete Record";
            // 
            // HistoryTableLayout
            // 
            this.HistoryTableLayout.BackColor = System.Drawing.Color.Transparent;
            this.HistoryTableLayout.ColumnCount = 4;
            this.HistoryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.HistoryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.HistoryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.HistoryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HistoryTableLayout.Controls.Add(this.ExportButton, 2, 0);
            this.HistoryTableLayout.Controls.Add(this.ClearButton, 0, 0);
            this.HistoryTableLayout.Controls.Add(this.HistoryListview, 0, 2);
            this.HistoryTableLayout.Controls.Add(this.Splitter, 0, 1);
            this.HistoryTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryTableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.HistoryTableLayout.Location = new System.Drawing.Point(40, 40);
            this.HistoryTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.HistoryTableLayout.Name = "HistoryTableLayout";
            this.HistoryTableLayout.RowCount = 3;
            this.HistoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.HistoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.HistoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HistoryTableLayout.Size = new System.Drawing.Size(858, 783);
            this.HistoryTableLayout.TabIndex = 1;
            // 
            // ExportButton
            // 
            this.ExportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportButton.BackColor = System.Drawing.Color.Transparent;
            this.ExportButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExportButton.Depth = 0;
            this.ExportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExportButton.HighEmphasis = true;
            this.ExportButton.Icon = ((System.Drawing.Image)(resources.GetObject("ExportButton.Icon")));
            this.ExportButton.Location = new System.Drawing.Point(194, 6);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExportButton.Size = new System.Drawing.Size(122, 38);
            this.ExportButton.TabIndex = 5;
            this.ExportButton.Text = "Export";
            this.ExportButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExportButton.UseAccentColor = false;
            this.ExportButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ClearButton.Depth = 0;
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Transparent;
            this.ClearButton.HighEmphasis = true;
            this.ClearButton.Icon = ((System.Drawing.Image)(resources.GetObject("ClearButton.Icon")));
            this.ClearButton.Location = new System.Drawing.Point(4, 6);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClearButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ClearButton.Size = new System.Drawing.Size(172, 38);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear History";
            this.ClearButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClearButton.UseAccentColor = false;
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(119)))));
            this.HistoryTableLayout.SetColumnSpan(this.Splitter, 4);
            this.Splitter.Depth = 0;
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Splitter.Location = new System.Drawing.Point(3, 53);
            this.Splitter.MouseState = MaterialSkin.MouseState.HOVER;
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(852, 2);
            this.Splitter.TabIndex = 6;
            // 
            // HistoryView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HistoryTableLayout);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HistoryView";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(938, 863);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.HistoryContextMenu.ResumeLayout(false);
            this.HistoryTableLayout.ResumeLayout(false);
            this.HistoryTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader TimeStampColumnHeader;
        private System.Windows.Forms.ColumnHeader DurationColumnHeader;
        private System.Windows.Forms.ColumnHeader StatusColumnHeader;
        private System.Windows.Forms.TableLayoutPanel HistoryTableLayout;
        private MaterialSkin.Controls.MaterialDivider Splitter;
        private MaterialSkin.Controls.MaterialContextMenuStrip HistoryContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteRecordToolStripMenuItem;
        public MaterialSkin.Controls.MaterialListView HistoryListview;
        public MaterialSkin.Controls.MaterialButton ExportButton;
        public MaterialSkin.Controls.MaterialButton ClearButton;
    }
}
