using System;
using System.Windows.Forms;
using KeyloggerEvader.Controllers;
using KeyloggerEvader.Helpers;

namespace KeyloggerEvader.Views
{
    public partial class HistoryView : UserControl
    {
        #region "Properties"
        public HistoryController Controller { get; private set; }
        #endregion

        public HistoryView()
        {
            InitializeComponent();
            Controller = new HistoryController(this);
        }

        #region "View LifeCycle"
        private void OnViewLoad(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            ListviewHelper.ResizeColumn(HistoryListview, HistoryListview.Columns.Count - 1);
        }
        #endregion
    }
}