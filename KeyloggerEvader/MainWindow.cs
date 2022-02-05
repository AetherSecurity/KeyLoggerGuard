using System;
using KeyloggerEvader.Controllers;
using MaterialSkin.Controls;

namespace KeyloggerEvader
{
    public partial class MainWindow : MaterialForm
    {
        #region "Properties"
        public MainController Controller { get; private set; }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            Controller = new MainController(this);
        }

        #region "MainWindow Lifecycle"
        private void OnApplicationLoad(object sender, EventArgs e)
        {
            Controller.AddTabMenuViews();
        }
        #endregion
    }
}