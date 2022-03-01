using System;
using System.Collections.Generic;
using KeyloggerEvader.Enums;

namespace KeyloggerEvader.Models
{
    public class HistoryModel
    {
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
            return null;
        }
    }
}