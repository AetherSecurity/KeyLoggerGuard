using KeyloggerEvader.Views;

namespace KeyloggerEvader.Controllers
{
    public class MainController
    {
        #region "Fields"
        private readonly MainWindow mainWindow;
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
                mainWindow.AboutUsTabPage.Controls.Add(new AboutUsView());
                mainWindow.SandboxTabPage.Controls.Add(new SandBoxView());
                mainWindow.HistoryTabPage.Controls.Add(new HistoryView());
                mainWindow.SettingsTabPage.Controls.Add(new SettingsView());
            }
        }
        #endregion
    }
}