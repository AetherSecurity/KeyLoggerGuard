using System;
using System.Windows.Forms;
using KeyloggerEvader.Helpers;

namespace KeyloggerEvader.Views
{
    public partial class HistoryView : UserControl
    {
        public HistoryView()
        {
            InitializeComponent();
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