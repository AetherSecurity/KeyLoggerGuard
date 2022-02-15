namespace KeyloggerEvader.Views
{
    partial class AboutUsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsView));
            this.HeaderCard = new MaterialSkin.Controls.MaterialCard();
            this.StealBodyFaqLabel = new MaterialSkin.Controls.MaterialLabel();
            this.StealFaqLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RiskBodyFaqLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RiskFaqLabel = new MaterialSkin.Controls.MaterialLabel();
            this.FAQLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AboutBodyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AboutLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MissionBodyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MissionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.HeaderCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderCard
            // 
            this.HeaderCard.AutoScroll = true;
            this.HeaderCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeaderCard.Controls.Add(this.StealBodyFaqLabel);
            this.HeaderCard.Controls.Add(this.StealFaqLabel);
            this.HeaderCard.Controls.Add(this.RiskBodyFaqLabel);
            this.HeaderCard.Controls.Add(this.RiskFaqLabel);
            this.HeaderCard.Controls.Add(this.FAQLabel);
            this.HeaderCard.Controls.Add(this.AboutBodyLabel);
            this.HeaderCard.Controls.Add(this.AboutLabel);
            this.HeaderCard.Controls.Add(this.MissionBodyLabel);
            this.HeaderCard.Controls.Add(this.MissionLabel);
            this.HeaderCard.Depth = 0;
            this.HeaderCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeaderCard.Location = new System.Drawing.Point(40, 40);
            this.HeaderCard.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.HeaderCard.Name = "HeaderCard";
            this.HeaderCard.Padding = new System.Windows.Forms.Padding(20);
            this.HeaderCard.Size = new System.Drawing.Size(858, 783);
            this.HeaderCard.TabIndex = 0;
            // 
            // StealBodyFaqLabel
            // 
            this.StealBodyFaqLabel.Depth = 0;
            this.StealBodyFaqLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StealBodyFaqLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StealBodyFaqLabel.Location = new System.Drawing.Point(20, 461);
            this.StealBodyFaqLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StealBodyFaqLabel.Name = "StealBodyFaqLabel";
            this.StealBodyFaqLabel.Size = new System.Drawing.Size(818, 75);
            this.StealBodyFaqLabel.TabIndex = 8;
            this.StealBodyFaqLabel.Text = resources.GetString("StealBodyFaqLabel.Text");
            // 
            // StealFaqLabel
            // 
            this.StealFaqLabel.Depth = 0;
            this.StealFaqLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StealFaqLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StealFaqLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.StealFaqLabel.HighEmphasis = true;
            this.StealFaqLabel.Location = new System.Drawing.Point(20, 422);
            this.StealFaqLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StealFaqLabel.Name = "StealFaqLabel";
            this.StealFaqLabel.Size = new System.Drawing.Size(818, 39);
            this.StealFaqLabel.TabIndex = 7;
            this.StealFaqLabel.Text = "How can hackers steal my data?";
            this.StealFaqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StealFaqLabel.UseAccent = true;
            // 
            // RiskBodyFaqLabel
            // 
            this.RiskBodyFaqLabel.Depth = 0;
            this.RiskBodyFaqLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RiskBodyFaqLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RiskBodyFaqLabel.Location = new System.Drawing.Point(20, 381);
            this.RiskBodyFaqLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RiskBodyFaqLabel.Name = "RiskBodyFaqLabel";
            this.RiskBodyFaqLabel.Size = new System.Drawing.Size(818, 41);
            this.RiskBodyFaqLabel.TabIndex = 6;
            this.RiskBodyFaqLabel.Text = "Running unknown software, downloading videos or other files from unknown sources," +
    " or visiting unverified websites could potentially infect your PC, allowing  to " +
    "access your personal data.";
            // 
            // RiskFaqLabel
            // 
            this.RiskFaqLabel.Depth = 0;
            this.RiskFaqLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RiskFaqLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RiskFaqLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.RiskFaqLabel.HighEmphasis = true;
            this.RiskFaqLabel.Location = new System.Drawing.Point(20, 342);
            this.RiskFaqLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RiskFaqLabel.Name = "RiskFaqLabel";
            this.RiskFaqLabel.Size = new System.Drawing.Size(818, 39);
            this.RiskFaqLabel.TabIndex = 5;
            this.RiskFaqLabel.Text = "What\'s the risk?";
            this.RiskFaqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RiskFaqLabel.UseAccent = true;
            // 
            // FAQLabel
            // 
            this.FAQLabel.Depth = 0;
            this.FAQLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FAQLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.FAQLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.FAQLabel.HighEmphasis = true;
            this.FAQLabel.Location = new System.Drawing.Point(20, 268);
            this.FAQLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FAQLabel.Name = "FAQLabel";
            this.FAQLabel.Size = new System.Drawing.Size(818, 74);
            this.FAQLabel.TabIndex = 4;
            this.FAQLabel.Text = "FAQ";
            this.FAQLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FAQLabel.UseAccent = true;
            // 
            // AboutBodyLabel
            // 
            this.AboutBodyLabel.Depth = 0;
            this.AboutBodyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutBodyLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AboutBodyLabel.Location = new System.Drawing.Point(20, 218);
            this.AboutBodyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutBodyLabel.Name = "AboutBodyLabel";
            this.AboutBodyLabel.Size = new System.Drawing.Size(818, 50);
            this.AboutBodyLabel.TabIndex = 3;
            this.AboutBodyLabel.Text = "Keylogger evader lets you run apps, download files, and visit websites in a \r\nsec" +
    "ure virtual environment isolated from the rest of your computer.";
            this.AboutBodyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutBodyLabel.UseAccent = true;
            // 
            // AboutLabel
            // 
            this.AboutLabel.Depth = 0;
            this.AboutLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AboutLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.AboutLabel.HighEmphasis = true;
            this.AboutLabel.Location = new System.Drawing.Point(20, 144);
            this.AboutLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(818, 74);
            this.AboutLabel.TabIndex = 2;
            this.AboutLabel.Text = "About";
            this.AboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutLabel.UseAccent = true;
            // 
            // MissionBodyLabel
            // 
            this.MissionBodyLabel.Depth = 0;
            this.MissionBodyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MissionBodyLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MissionBodyLabel.Location = new System.Drawing.Point(20, 94);
            this.MissionBodyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MissionBodyLabel.Name = "MissionBodyLabel";
            this.MissionBodyLabel.Size = new System.Drawing.Size(818, 50);
            this.MissionBodyLabel.TabIndex = 0;
            this.MissionBodyLabel.Text = "To provide the most secured anti keylogger.";
            this.MissionBodyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MissionBodyLabel.UseAccent = true;
            // 
            // MissionLabel
            // 
            this.MissionLabel.Depth = 0;
            this.MissionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MissionLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MissionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.MissionLabel.HighEmphasis = true;
            this.MissionLabel.Location = new System.Drawing.Point(20, 20);
            this.MissionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MissionLabel.Name = "MissionLabel";
            this.MissionLabel.Size = new System.Drawing.Size(818, 74);
            this.MissionLabel.TabIndex = 1;
            this.MissionLabel.Text = "- Our Mission -";
            this.MissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MissionLabel.UseAccent = true;
            // 
            // AboutUsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HeaderCard);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AboutUsView";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(938, 863);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.HeaderCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard HeaderCard;
        private MaterialSkin.Controls.MaterialLabel MissionBodyLabel;
        private MaterialSkin.Controls.MaterialLabel MissionLabel;
        private MaterialSkin.Controls.MaterialLabel AboutLabel;
        private MaterialSkin.Controls.MaterialLabel AboutBodyLabel;
        private MaterialSkin.Controls.MaterialLabel StealBodyFaqLabel;
        private MaterialSkin.Controls.MaterialLabel StealFaqLabel;
        private MaterialSkin.Controls.MaterialLabel RiskBodyFaqLabel;
        private MaterialSkin.Controls.MaterialLabel RiskFaqLabel;
        private MaterialSkin.Controls.MaterialLabel FAQLabel;
    }
}
