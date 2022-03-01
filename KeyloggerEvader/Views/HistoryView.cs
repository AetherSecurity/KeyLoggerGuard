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
                HistoryListview.Items.Remove(selectedItem);
                Controller.RemoveHistoryRecord((HistoryModel)selectedItem.Tag);
            }
        }

        private void ClearHistoryButtonClick(object sender, EventArgs e)
        {
            HistoryListview.Items.Clear();
            Controller.ClearHistory();
        }

        private void ExportHistoryButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem record in HistoryListview.Items)
            {
                //Create a txt file, chosen by the user, save it in a specific location.
                //Write each record into the text file, should be formatted.
            }
        }
        #endregion
    }
}