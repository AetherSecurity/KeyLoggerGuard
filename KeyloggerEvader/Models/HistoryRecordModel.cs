using System;

namespace KeyloggerEvader.Models
{
    public class HistoryRecordModel
    {
        #region "Fields"
        public static readonly string filePath = AppDomain.CurrentDomain.BaseDirectory + "//History.json";
        #endregion

        #region "Properties"
       public string Id { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public string FileExtension { get; set; }

        public string StartupTime { get; set; }

        public string Duration { get; set; }

        public string FileStatus { get; set; }
        #endregion

        public HistoryRecordModel(string Id, string FileName, string FilePath, string FileExtension , string StartupTime, string Duration, string FileStatus)
        {
            this.Id = Id;
            this.FileName = FileName;
            this.FilePath = FilePath;
            this.FileExtension = FileExtension;
            this.StartupTime = StartupTime;
            this.Duration = Duration;
            this.FileStatus = FileStatus;
        }

        public HistoryRecordModel()
        {
        }

        public override string ToString()
        {
            return string.Format("[{0}\t{1}\t{0}\t{0}\t{0}\t{0}\t{0}]", Id, FileName, FilePath, FileExtension, StartupTime, Duration, FileStatus);
        }
    }
}