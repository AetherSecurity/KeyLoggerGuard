using System;
using KeyloggerEvader.Controllers;
using MaterialSkin.Controls;

namespace KeyloggerEvader
{
    public partial class MainWindow : MaterialForm
    {
        #region "Properties"
        //This is the controller that will be able to communicate with the MainWindow.
        //It is public and has get and set methods, but the set is private because
        //it will only be initialized in the MainWindow Class.
        public MainController Controller { get; private set; }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            Controller = new MainController(this);
        }

        //Application Lifecycle: Start -> Create -> Show -> Close -> Terminate
        #region "MainWindow Lifecycle"
        private void OnApplicationLoad(object sender, EventArgs e) //Method
        {
            //Implementation
            Controller.AddTabMenuViews();
        }
        #endregion
    }
}