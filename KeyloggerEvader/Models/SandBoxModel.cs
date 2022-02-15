using System.IO;
using KeyloggerEvader.Enums;

namespace KeyloggerEvader.Models
{
    public class SandBoxModel
    {
        #region "Properties"
        public FileInfo FileInfo { get; set; }

        public FileStatus FileStatus { get; set; }
        #endregion

        #region "Constructors / Destructor"
        public SandBoxModel(FileInfo FileInfo, FileStatus FileStatus)
        {
            this.FileInfo = FileInfo;
            this.FileStatus = FileStatus;
        }

        ~SandBoxModel()
        {
        }
        #endregion
    }
}