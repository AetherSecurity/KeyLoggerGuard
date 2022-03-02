using System;
using System.Windows.Forms;
using KeyloggerEvader.Controllers;
using KeyloggerEvader.Helpers;
using KeyloggerEvader.Models;

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

        #region "View Event Handlers"
        private void OnViewLoad(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            ListviewHelper.ResizeColumn(HistoryListview, HistoryListview.Columns.Count - 1);
        }

        private void DeleteHistoryRecordToolStripMenuItemClick(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in HistoryListview.SelectedItems)
            {
                Controller.RemoveRecord((HistoryRecordModel)selectedItem.Tag);
            }
        }

        private void ClearHistoryButtonClick(object sender, EventArgs e)
        {
            HistoryListview.Items.Clear();
            Controller.ClearHistoryRecords();
        }

        private void ExportHistoryButtonClick(object sender, EventArgs e)
        {
            Controller.ExportHistoryRecords();
        }
        #endregion
    }
}