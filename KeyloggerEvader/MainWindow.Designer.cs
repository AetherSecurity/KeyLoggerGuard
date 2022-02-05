namespace KeyloggerEvader
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.AboutUsTabPage = new System.Windows.Forms.TabPage();
            this.SandboxTabPage = new System.Windows.Forms.TabPage();
            this.HistoryTabPage = new System.Windows.Forms.TabPage();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.MainMenuImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.AboutUsTabPage);
            this.MainMenu.Controls.Add(this.SandboxTabPage);
            this.MainMenu.Controls.Add(this.HistoryTabPage);
            this.MainMenu.Controls.Add(this.SettingsTabPage);
            this.MainMenu.Depth = 0;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Font = new System.Drawing.Font("Courier New", 12F);
            this.MainMenu.ImageList = this.MainMenuImageList;
            this.MainMenu.ItemSize = new System.Drawing.Size(120, 40);
            this.MainMenu.Location = new System.Drawing.Point(3, 88);
            this.MainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainMenu.Multiline = true;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Drawing.Point(0, 0);
            this.MainMenu.SelectedIndex = 0;
            this.MainMenu.Size = new System.Drawing.Size(954, 549);
            this.MainMenu.TabIndex = 0;
            // 
            // AboutUsTabPage
            // 
            this.AboutUsTabPage.ImageKey = "AboutUs.png";
            this.AboutUsTabPage.Location = new System.Drawing.Point(4, 44);
            this.AboutUsTabPage.Name = "AboutUsTabPage";
            this.AboutUsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AboutUsTabPage.Size = new System.Drawing.Size(946, 501);
            this.AboutUsTabPage.TabIndex = 0;
            this.AboutUsTabPage.Text = "About Us";
            this.AboutUsTabPage.UseVisualStyleBackColor = true;
            // 
            // SandboxTabPage
            // 
            this.SandboxTabPage.ImageKey = "Sandbox.png";
            this.SandboxTabPage.Location = new System.Drawing.Point(4, 44);
            this.SandboxTabPage.Name = "SandboxTabPage";
            this.SandboxTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SandboxTabPage.Size = new System.Drawing.Size(946, 501);
            this.SandboxTabPage.TabIndex = 1;
            this.SandboxTabPage.Text = "Sandbox";
            this.SandboxTabPage.UseVisualStyleBackColor = true;
            // 
            // HistoryTabPage
            // 
            this.HistoryTabPage.ImageKey = "History.png";
            this.HistoryTabPage.Location = new System.Drawing.Point(4, 44);
            this.HistoryTabPage.Name = "HistoryTabPage";
            this.HistoryTabPage.Size = new System.Drawing.Size(946, 501);
            this.HistoryTabPage.TabIndex = 2;
            this.HistoryTabPage.Text = "History";
            this.HistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.ImageKey = "Settings.png";
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 44);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Size = new System.Drawing.Size(946, 501);
            this.SettingsTabPage.TabIndex = 3;
            this.SettingsTabPage.Text = "Settings";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainMenuImageList
            // 
            this.MainMenuImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainMenuImageList.ImageStream")));
            this.MainMenuImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainMenuImageList.Images.SetKeyName(0, "AboutUs.png");
            this.MainMenuImageList.Images.SetKeyName(1, "Sandbox.png");
            this.MainMenuImageList.Images.SetKeyName(2, "History.png");
            this.MainMenuImageList.Images.SetKeyName(3, "Settings.png");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.MainMenu);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.MainMenu;
            this.DrawerUseColors = true;
            this.DrawerWidth = 300;
            this.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 640);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Text = "Keylogger Evader";
            this.Load += new System.EventHandler(this.OnApplicationLoad);
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList MainMenuImageList;
        public MaterialSkin.Controls.MaterialTabControl MainMenu;
        public System.Windows.Forms.TabPage AboutUsTabPage;
        public System.Windows.Forms.TabPage SandboxTabPage;
        public System.Windows.Forms.TabPage HistoryTabPage;
        public System.Windows.Forms.TabPage SettingsTabPage;
    }
}

