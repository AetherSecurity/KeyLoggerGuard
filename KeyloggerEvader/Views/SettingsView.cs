using System;
using System.Windows.Forms;
using KeyloggerEvader.Controllers;
using KeyloggerEvader.Helpers;

namespace KeyloggerEvader.Views
{
    public partial class SettingsView : UserControl
    {
        #region "Properties"
        public SettingsController Controller { get; private set; }
        #endregion

        public SettingsView()
        {
            InitializeComponent();
            SetControlsDoubleBuffered();
            Controller = new SettingsController(this);
        }

        #region "View LifeCycle"
        private void OnViewLoad(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            Controller.LoadData();
            ThemeSettingsExpansionPanel.SaveClick += ThemeSettingsExpansionPanelSaveClick;
            ApplicationSettingsExpansionPanel.SaveClick += ApplicationSettingsExpansionPanelSaveClick;
        }
        #endregion

        #region "Click Events"
        private void ThemeSettingsExpansionPanelSaveClick(object sender, EventArgs e)
        {
            Controller.SaveThemeSettings();
        }
        
        private void ApplicationSettingsExpansionPanelSaveClick(object sender, EventArgs e)
        {
            Controller.SaveApplicationSettings();
        }
        #endregion

        #region "Double Buffered"
        private void SetControlsDoubleBuffered()
        {
            foreach (Control Ctrl in Controls)
            {
                ViewHelper.SetDoubleBuffered(Ctrl);
                foreach (Control CtrlChild in Ctrl.Controls)
                {
                    ViewHelper.SetDoubleBuffered(CtrlChild);
                }
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion
    }
}