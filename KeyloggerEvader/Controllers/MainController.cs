using KeyloggerEvader.Views;

namespace KeyloggerEvader.Controllers
{
    public class MainController
    {
        #region "Fields"
        private readonly MainWindow mainWindow;
        #endregion

        #region "Properties"
        public AboutUsView AboutUsView { get; private set; }

        public SandBoxView SandBoxView { get; private set; }

        public HistoryView HistoryView { get; private set; }

        public SettingsView SettingsView { get; private set; }
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

        #region "Private Methods"
        private void InitializeViews()
        {
            AboutUsView = new AboutUsView();
            SandBoxView = new SandBoxView();
            HistoryView = new HistoryView();
            SettingsView = new SettingsView();
        }
        #endregion

        #region "Public Methods"
        public void AddTabMenuViews()
        {
            if (mainWindow != null)
            {
                InitializeViews();
                mainWindow.AboutUsTabPage.Controls.Add(AboutUsView);
                mainWindow.SandboxTabPage.Controls.Add(SandBoxView);
                mainWindow.HistoryTabPage.Controls.Add(HistoryView);
                mainWindow.SettingsTabPage.Controls.Add(SettingsView);
            }
        }
        #endregion
    }
}