using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using KeyloggerEvader.Enums;
using KeyloggerEvader.Views;
using KeyloggerEvader.Models;
using KeyloggerEvader.Utilities;

namespace KeyloggerEvader.Controllers
{
    public class SandBoxController
    {
        #region "Fields"
        private readonly SandBoxView sandBoxView;
        #endregion

        #region "Properties"
        public List<SandBoxModel> SandBoxes { get; set; }

        public IntPtr CurrentDesktopScreen { get; private set; }
        #endregion

        #region "Constructors / Destructor"
        public SandBoxController(SandBoxView sandBoxView)
        {
            this.sandBoxView = sandBoxView;
            Initialize();
        }

        ~SandBoxController()
        {
        }
        #endregion

        #region "Private Methods"
        private void Initialize()
        {
            SandBoxes = new List<SandBoxModel>();
            CurrentDesktopScreen = User32.GetThreadDesktop(User32.GetCurrentThreadId());
        }

        private void AddFilesToListview(SandBoxModel sandBoxModel)
        {
            ListViewItem item = new ListViewItem(sandBoxModel.FileInfo.Name);
            item.SubItems.Add(sandBoxModel.FileInfo.Extension);
            item.SubItems.Add(sandBoxModel.FileInfo.FullName);
            item.SubItems.Add(sandBoxModel.FileStatus.ToString());
            item.Name = sandBoxModel.GetHashCode().ToString();
            item.Tag = sandBoxModel;


            sandBoxView.FilesListview.Items.Add(item);
        }

        private void UpdateStatus(SandBoxModel sandBoxModel)
        {
        }
        #endregion

        #region "Public Methods"
        public void ProcessFiles(string[] filesPath)
        {
            //Loop thorugh each file.
            foreach (string filePath in filesPath)
            {
                //Create a FileInfo Object by passing the file path.
                FileInfo fileInfo = new FileInfo(filePath);
                //Get the file attributes to check if its a directory or an executable file.
                FileAttributes fileAttributes = File.GetAttributes(fileInfo.FullName);
                //If the fileAttributes was not directory then add the file into the fileInfoList
                if (!((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory))
                {
                    //If the file is not added in the InputFiles then add it otherwise do nothing.
                    if (!(SandBoxes.Exists(s => s.FileInfo.Name.Equals(fileInfo.Name) && s.FileInfo.FullName.Equals(fileInfo.FullName))))
                    {
                        //Add a new sandBox that contains the fileinfo and file status into the InputFiles and FilesListview.
                        SandBoxModel sandBox = new SandBoxModel(fileInfo, FileStatus.Running);
                        SandBoxes.Add(sandBox);
                        AddFilesToListview(sandBox);
                    }
                }
            }
        }

        public Task Run(SandBoxModel singleSandbox = null)
        {
            //Creates a new task and will be executed in the ThreadPool.
            return Task.Run(() =>
            {
                //Check if the singleSandbox is not null then we will run the single sandbox.
                if (singleSandbox != null)
                {
                    //Run Singular.
                }
                else //Otherwise run all the sandboxes that has a status of "Ready".
                {
                    //Loop through each sandbox.
                    foreach (SandBoxModel sandBox in SandBoxes)
                    {
                        //Check if the sandbox status is Ready.
                        if (sandBox.FileStatus.Equals(FileStatus.Ready))
                        {
                            //Run All.
                        }
                    }
                }
            });
        }
        #endregion
    }
}