using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using KeyloggerEvader.Models;
using KeyloggerEvader.Views;
using Newtonsoft.Json;

namespace KeyloggerEvader.Controllers
{
    public class HistoryController
    {
        #region "Fields"
        private readonly HistoryView historyView;
        #endregion

        #region "Properties"
        public List<HistoryModel> Records { get; private set; }
        #endregion

        #region "Constructors / Destructor"
        public HistoryController(HistoryView historyView)
        {
            this.historyView = historyView;
            Initialize();
        }

        ~HistoryController()
        {
            Records.Clear();
            Records = null;
        }
        #endregion

        #region "Private Methods"
        private void Initialize()
        {
            CreateHistoryFile();
            Records = HistoryModel.GetHistoryLogs();
            AddRecords();
        }

        private bool CreateHistoryFile()
        {
            try
            {
                if (File.Exists(HistoryModel.filePath) == false)
                {
                    FileStream FS = File.Create(HistoryModel.filePath);
                    FS.Dispose();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void AddRecords()
        {
            if (Records.Count > 0)
            {
                foreach (HistoryModel record in Records.ToArray())
                {
                    AddToListView(record);
                }
            }
        }

        private void UpdateHistoryRecords()
        {
            File.Delete(HistoryModel.filePath);
            if (Records.Count > 0)
            {
                if (CreateHistoryFile())
                {
                    string JsonContent = JsonConvert.SerializeObject(Records);
                    using (FileStream FS = new FileStream(HistoryModel.filePath, FileMode.Open, FileAccess.ReadWrite))
                    {
                        using (StreamWriter SW = new StreamWriter(FS))
                        {
                            SW.Write(JsonContent);
                            SW.Flush();
                        }
                    }
                }
            }
        }
        #endregion

        #region "Public Methods"
        public void AddToListView(HistoryModel historyModel)
        {
            ListViewItem item = new ListViewItem(historyModel.Name);
            item.SubItems.Add(historyModel.TimeStamp.ToString());
            item.SubItems.Add(historyModel.Duration.ToString());
            item.SubItems.Add(historyModel.Status.ToString());
            item.Name = historyModel.GetHashCode().ToString();
            item.Tag = historyModel;
            historyView.HistoryListview.Items.Add(item);
            Records.Add(historyModel);
            UpdateHistoryRecords();
        }

        public void RemoveHistoryRecord(HistoryModel record)
        {
            Records.Remove(record);
            UpdateHistoryRecords();
        }

        public void ClearHistory()
        {
            Records.Clear();
            UpdateHistoryRecords();
        }
        #endregion
    }
}