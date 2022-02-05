using MaterialSkin;
using System.Windows.Forms;

namespace KeyloggerEvader
{
    public sealed class App
    {
        #region "Properties"
        public MaterialSkinManager SkinManager { get; private set; }

        public MainWindow MainWindowInstance { get; private set; }

        public static App Instance { get; private set; }
        #endregion

        #region "Constructors / Destructors"
        public App()
        {
            Instance = this;
            ConfigureApplication();
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
        private void ConfigureSkinManager()
        {
            SkinManager = MaterialSkinManager.Instance;
            SkinManager.EnforceBackcolorOnAllComponents = true;
            SkinManager.AddFormToManage(MainWindowInstance);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        #endregion

        #region "Application"
        private void ConfigureApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        private void LaunchApplication()
        {
            MainWindowInstance = new MainWindow();
            ConfigureSkinManager();
            Application.Run(MainWindowInstance);
        }
        #endregion
    }
}