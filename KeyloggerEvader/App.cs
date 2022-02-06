using System.Windows.Forms;
using MaterialSkin;
using KeyloggerEvader.Models;

namespace KeyloggerEvader
{
    public sealed class App
    {
        #region "Properties"
        public SettingsModel Settings { get; private set; }

        public MaterialSkinManager SkinManager { get; private set; }

        public MainWindow MainWindowInstance { get; private set; }

        public static App Instance { get; private set; }
        #endregion

        #region "Constructors / Destructors"
        public App()
        {
            Instance = this;
            Settings = SettingsModel.GetUserSettings();
            SkinManager = MaterialSkinManager.Instance;
            LaunchApplication();
        }

        ~App()
        {
            SkinManager.RemoveFormToManage(MainWindowInstance);
            MainWindowInstance = null;
            Instance = null;
        }
        #endregion

        #region "Skin"
        public void ConfigureSkinManager()
        {
            ApplyTheme();
            ApplyColorScheme();
            ApplyApplicationStyle();
        }

        public void ApplyTheme()
        {
            SkinManager.Theme = Settings.ThemeOption;
        }

        public void ApplyColorScheme()
        {
            SkinManager.ColorScheme = new ColorScheme(Settings.Primary, Settings.DarkPrimary, Settings.LightPrimary, Settings.Accent, Settings.TextShading);
        }

        public void ApplyApplicationStyle()
        {
            MainWindowInstance.DrawerUseColors = Settings.TabMenuUseColors;
            MainWindowInstance.DrawerHighlightWithAccent = Settings.TabMenuHighlightWithAccent;
            MainWindowInstance.DrawerBackgroundWithAccent = Settings.TabMenuBackgroundWithAccent;
            MainWindowInstance.DrawerShowIconsWhenHidden = Settings.TabMenuDisplayIconsWhenHidden;
            MainWindowInstance.DrawerAutoShow = Settings.TabMenuAutoShow;
            MainWindowInstance.FormStyle = Settings.FormStyle;
        }
        #endregion

        #region "Application"
        private void ConfigureApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindowInstance = new MainWindow();
            SkinManager.AddFormToManage(MainWindowInstance);
        }
        private void LaunchApplication()
        {
            ConfigureApplication();
            ConfigureSkinManager();
            Application.Run(MainWindowInstance);
        }
        #endregion
    }
}