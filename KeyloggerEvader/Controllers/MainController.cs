using KeyloggerEvader.Views;

namespace KeyloggerEvader.Controllers
{
    public class MainController
    {
        #region "Fields"
        private readonly MainWindow mainWindow;
        #endregion

        #region "Properties"
        public AboutUsView AboutUsView { get; private set; } = new AboutUsView();

        public SandBoxView SandBoxView { get; private set; } = new SandBoxView();

        public HistoryView HistoryView { get; private set; } = new HistoryView();

        public SettingsView SettingsView { get; private set; } = new SettingsView();
        #endregion

        #region "Constructors / Destructor"
        public MainController(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        ~MainController()
        {
        }
        #endregion


        #region "TabMenu"
        public void AddTabMenuViews()
        {
            if (mainWindow != null)
            {
                mainWindow.AboutUsTabPage.Controls.Add(AboutUsView);
                mainWindow.SandboxTabPage.Controls.Add(SandBoxView);
                mainWindow.HistoryTabPage.Controls.Add(HistoryView);
                mainWindow.SettingsTabPage.Controls.Add(SettingsView);
            }
        }
        #endregion
    }
}