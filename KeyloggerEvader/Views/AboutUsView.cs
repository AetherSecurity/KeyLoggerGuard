using System;
using System.Windows.Forms;

namespace KeyloggerEvader.Views
{
    public partial class AboutUsView : UserControl
    {
        public AboutUsView()
        {
            InitializeComponent();
        }

        #region "View LifeCycle"
        private void OnViewLoad(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
        #endregion
    }
}