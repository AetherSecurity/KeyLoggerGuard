using KeyloggerEvader.Models;
using KeyloggerEvader.Views;
using System.Windows.Forms;

namespace KeyloggerEvader.Controllers
{
    public class HistoryController
    {
        #region "Fields"
        private readonly HistoryView historyView;
        #endregion

        #region "Properties"
        #endregion

        #region "Constructors / Destructor"
        public HistoryController(HistoryView historyView)
        {
            this.historyView = historyView;
        }

        ~HistoryController()
        {
        }
        #endregion

        #region "Private Methods"
        private void AddToListView(HistoryModel historyModel)
        {
            ListViewItem item = new ListViewItem(historyModel.Name);
            item.SubItems.Add(historyModel.TimeStamp.ToString());
            item.SubItems.Add(historyModel.Duration.ToString());
            item.SubItems.Add(historyModel.Status.ToString());
            item.Name = historyModel.GetHashCode().ToString();
            item.Tag = historyModel;
            historyView.HistoryListview.Items.Add(item);
        }
        #endregion
    }
}