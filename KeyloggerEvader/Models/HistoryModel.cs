using System;
using System.IO;
using System.Collections.Generic;
using KeyloggerEvader.Enums;
using Newtonsoft.Json;

namespace KeyloggerEvader.Models
{
    public class HistoryModel
    {
        #region "Fields"
        public static readonly string filePath = AppDomain.CurrentDomain.BaseDirectory + "//History.json";
        #endregion

        #region "Properties"
        public string Name { get; set; }

        public DateTime TimeStamp { get; set; }

        public TimeSpan Duration { get; set; }

        public FileStatus Status { get; set; }
        #endregion

        public HistoryModel(string Name, DateTime TimeStamp, TimeSpan Duration, FileStatus Status)
        {
            this.Name = Name;
            this.TimeStamp = TimeStamp;
            this.Duration = Duration;
            this.Status = Status;
        }

        public HistoryModel()
        {
        }

        public static List<HistoryModel> GetHistoryLogs()
        {
            List<HistoryModel> records;
            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(jsonContent) == false)
                {
                    records = JsonConvert.DeserializeObject<List<HistoryModel>>(jsonContent);
                }
                else
                {
                    records = new List<HistoryModel>();
                }
            }
            else
            {
                records = new List<HistoryModel>();
            }
            return records;
        }
    }
}