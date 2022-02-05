using KeyloggerEvader.Views;

namespace KeyloggerEvader.Controllers
{
    public class MainController
    {
        #region "Fields"
        private MainWindow MainWindow;
        #endregion

        public MainController(MainWindow MainWindow)
        {
            this.MainWindow = MainWindow;
        }

        #region "TabMenu"
        public void AddTabMenuViews()
        {
            if (MainWindow != null)
            {
                MainWindow.AboutUsTabPage.Controls.Add(new AboutUsView());
                MainWindow.SandboxTabPage.Controls.Add(new SandboxView());
                MainWindow.HistoryTabPage.Controls.Add(new HistoryView());
                MainWindow.SettingsTabPage.Controls.Add(new SettingsView());
            }
        }
        #endregion
    }
}