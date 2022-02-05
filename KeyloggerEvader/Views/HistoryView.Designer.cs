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
            this.HistoryTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ExportHistoryButton = new MaterialSkin.Controls.MaterialButton();
            this.HistoryTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryListview
            // 
            this.HistoryListview.AllowColumnReorder = true;
            this.HistoryListview.AutoSizeTable = true;
            this.HistoryListview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HistoryListview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistoryListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader,
            this.TimeStampColumnHeader,
            this.DurationColumnHeader,
            this.StatusColumnHeader});
            this.HistoryTableLayout.SetColumnSpan(this.HistoryListview, 2);
            this.HistoryListview.Depth = 0;
            this.HistoryListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.HistoryListview.FullRowSelect = true;
            this.HistoryListview.HideSelection = false;
            this.HistoryListview.Location = new System.Drawing.Point(3, 64);
            this.HistoryListview.MaximumSize = new System.Drawing.Size(868, 345);
            this.HistoryListview.MinimumSize = new System.Drawing.Size(868, 345);
            this.HistoryListview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.HistoryListview.MouseState = MaterialSkin.MouseState.OUT;
            this.HistoryListview.Name = "HistoryListview";
            this.HistoryListview.OwnerDraw = true;
            this.HistoryListview.Scrollable = false;
            this.HistoryListview.Size = new System.Drawing.Size(868, 345);
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
            // HistoryTableLayout
            // 
            this.HistoryTableLayout.ColumnCount = 2;
            this.HistoryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.HistoryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HistoryTableLayout.Controls.Add(this.HistoryListview, 0, 2);
            this.HistoryTableLayout.Controls.Add(this.ExportHistoryButton, 0, 0);
            this.HistoryTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryTableLayout.Location = new System.Drawing.Point(40, 40);
            this.HistoryTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.HistoryTableLayout.Name = "HistoryTableLayout";
            this.HistoryTableLayout.RowCount = 3;
            this.HistoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.58907F));
            this.HistoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.HistoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.41093F));
            this.HistoryTableLayout.Size = new System.Drawing.Size(866, 421);
            this.HistoryTableLayout.TabIndex = 1;
            // 
            // ExportHistoryButton
            // 
            this.ExportHistoryButton.AutoSize = false;
            this.ExportHistoryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.ExportHistoryButton.Depth = 0;
            this.ExportHistoryButton.DrawShadows = false;
            this.ExportHistoryButton.HighEmphasis = true;
            this.ExportHistoryButton.Icon = ((System.Drawing.Image)(resources.GetObject("ExportHistoryButton.Icon")));
            this.ExportHistoryButton.Location = new System.Drawing.Point(4, 6);
            this.ExportHistoryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExportHistoryButton.MaximumSize = new System.Drawing.Size(142, 39);
            this.ExportHistoryButton.MinimumSize = new System.Drawing.Size(142, 39);
            this.ExportHistoryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportHistoryButton.Name = "ExportHistoryButton";
            this.ExportHistoryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExportHistoryButton.Size = new System.Drawing.Size(142, 39);
            this.ExportHistoryButton.TabIndex = 1;
            this.ExportHistoryButton.Text = "Export";
            this.ExportHistoryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExportHistoryButton.UseAccentColor = false;
            this.ExportHistoryButton.UseVisualStyleBackColor = true;
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.HistoryTableLayout);
            this.Name = "HistoryView";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(946, 501);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.HistoryTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView HistoryListview;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader TimeStampColumnHeader;
        private System.Windows.Forms.ColumnHeader DurationColumnHeader;
        private System.Windows.Forms.ColumnHeader StatusColumnHeader;
        private System.Windows.Forms.TableLayoutPanel HistoryTableLayout;
        private MaterialSkin.Controls.MaterialButton ExportHistoryButton;
    }
}
