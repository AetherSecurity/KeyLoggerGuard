using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using KeyloggerEvader.Views;
using KeyloggerEvader.Models;
using KeyloggerEvader.Helpers;
using KeyloggerEvader.Extensions;

namespace KeyloggerEvader.Controllers
{
    public class HistoryController
    {
        #region "Fields"
        private readonly HistoryView historyView;
        #endregion

        #region "Properties"
        public List<HistoryRecordModel> HistoryRecords { get; private set; }
        
        public bool EnableHistoryLogging { get; private set; }
        #endregion

        #region "Constructors / Destructor"
        public HistoryController(HistoryView historyView)
        {
            this.historyView = historyView;
            Initialize();
        }

        ~HistoryController()
        {
            HistoryRecords.Clear();
            HistoryRecords = null;
        }
        #endregion

        #region "Private Methods"
        private void Initialize()
        {
            EnableHistoryLogging = App.Instance.Settings.HistoryLogging;
            HistoryRecords = GetHistoryRecords();
            AddRecordsToListview();
        }
        private bool CreateFile()
        {
            try
            {
                if (IsFileExists() == false)
                {
                    FileStream FS = new FileStream(HistoryRecordModel.filePath, FileMode.Create, FileAccess.ReadWrite);
                    FS.Dispose();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private bool DeleteFile()
        {
            try
            {
                if (IsFileExists())
                {
                    File.Delete(HistoryRecordModel.filePath);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private bool IsFileExists()
        {
            try
            {
                return File.Exists(HistoryRecordModel.filePath);
            }
            catch
            {
                return false;
            }
        }

        private bool WriteToFile()
        {
            try
            {
                if (DeleteFile())
                {
                    if (CreateFile())
                    {
                        using (FileStream FS = new FileStream(HistoryRecordModel.filePath, FileMode.Open, FileAccess.ReadWrite))
                        {
                            using (StreamWriter SW = new StreamWriter(FS))
                            {
                                SW.Write(JsonConvert.SerializeObject(HistoryRecords));
                                SW.Flush();
                                return true;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private List<HistoryRecordModel> GetHistoryRecords()
        {
            try
            {
                CreateFile();
                using (FileStream FS = new FileStream(HistoryRecordModel.filePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    using (StreamReader SR = new StreamReader(FS))
                    {
                        string jsonContent = SR.ReadToEnd();
                        if (string.IsNullOrEmpty(jsonContent) == false)
                        {
                            return JsonConvert.DeserializeObject<List<HistoryRecordModel>>(jsonContent);
                        }
                        else
                        {
                            return new List<HistoryRecordModel>();
                        }

                    }
                }
            }
            catch
            {
                return new List<HistoryRecordModel>();
            }
        }

        private void AddRecordsToListview()
        {
            foreach (HistoryRecordModel record in HistoryRecords)
            {
                AddRecordToListview(record);
            }
        }

        private void AddRecordToListview(HistoryRecordModel record)
        {
            historyView.SyncContext.Post(new SendOrPostCallback(s => 
            {
                ListViewItem item = new ListViewItem(record.Id);
                item.SubItems.Add(record.FileName);
                item.SubItems.Add(record.FileExtension);
                item.SubItems.Add(record.FilePath);
                item.SubItems.Add(record.StartupTime);
                item.SubItems.Add(record.Duration);
                item.SubItems.Add(record.FileStatus);
                item.Name = record.GetHashCode().ToString();
                item.Tag = record;
                historyView.HistoryListview.Items.Add(item);
                ListviewHelper.ResizeColumns(historyView.HistoryListview);
            }), null);
        }

        private void RemoveRecordFromListview(HistoryRecordModel record)
        {
            historyView.SyncContext.Post(new SendOrPostCallback(s =>
            {
                historyView.HistoryListview.Items.RemoveByKey(record.GetHashCode().ToString());
            }), null);
        }
        #endregion


        #region "Public Methods"
        public bool AddRecord(HistoryRecordModel newRecord)
        {
            try
            {
                if (EnableHistoryLogging)
                {
                    AddRecordToListview(newRecord);
                    HistoryRecords.Add(newRecord);
                    return WriteToFile();
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveRecord(HistoryRecordModel record)
        {
            try
            {
                if (EnableHistoryLogging)
                {
                    if (HistoryRecords.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if (HistoryRecords.Remove(h => h.Id.Equals(record.Id)))
                        {
                            RemoveRecordFromListview(record);
                            return WriteToFile();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ClearHistoryRecords()
        {
            try
            {
                if (EnableHistoryLogging)
                {
                    HistoryRecords.Clear();
                    return WriteToFile();
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ExportHistoryRecords()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Title = "Save History Records",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "txt",
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    RestoreDirectory = true
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream FS = new FileStream(saveFileDialog.FileName, FileMode.Open, FileAccess.ReadWrite))
                    {
                        using (StreamWriter SW = new StreamWriter(FS))
                        {
                            foreach (HistoryRecordModel record in HistoryRecords)
                            {
                                SW.WriteLine(record.ToString());
                            }
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}