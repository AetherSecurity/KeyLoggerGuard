using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using KeyloggerEvader.Enums;
using KeyloggerEvader.Views;
using KeyloggerEvader.Models;
using KeyloggerEvader.Helpers;
using KeyloggerEvader.Services;
using KeyloggerEvader.Utilities;

namespace KeyloggerEvader.Controllers
{
    public class SandBoxController
    {
        #region "Fields"
        private readonly SandBoxView sandBoxView;
        #endregion

        #region "Properties"
        public List<SandBoxModel> SandBoxes { get; private set; }

        public ISecuredDesktopService SecuredDesktop { get; private set; }
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
            SecuredDesktop = new SecuredDesktopService();
            SecuredDesktop.Initialize();
        }

        private void AddToListView(SandBoxModel sandBoxModel)
        {
            sandBoxView.SyncContext.Post(new SendOrPostCallback(s => 
            {
                ListViewItem item = new ListViewItem(sandBoxModel.FileInfo.Name);
                item.SubItems.Add(sandBoxModel.FileInfo.Extension);
                item.SubItems.Add(sandBoxModel.FileInfo.FullName);
                item.SubItems.Add(sandBoxModel.FileStatus.ToString());
                item.Name = sandBoxModel.GetHashCode().ToString();
                item.Tag = sandBoxModel;
                sandBoxView.FilesListview.Items.Add(item);
            }), null);
        }

        private void UpdateStatus(SandBoxModel sandBoxModel)
        {
            sandBoxView.SyncContext.Post(new SendOrPostCallback(s =>
            {
                string key = sandBoxModel.GetHashCode().ToString();
                if (sandBoxView.FilesListview.Items.ContainsKey(key))
                {
                    sandBoxView.FilesListview.Items[key].SubItems[3].Text = sandBoxModel.FileStatus.ToString();
                }
            }), null);
        }

        public void ExecuteSandBox(SandBoxModel sandBoxModel, string desktopName)
        {
            CustomProcess customProcess = new CustomProcess()
            {
                FileName = sandBoxModel.FileInfo.FullName
            };

            if (customProcess.Start(desktopName))
            {
                sandBoxModel.TimeStamp = DateTime.Now;
                sandBoxModel.FileStatus = FileStatus.Running;
                UpdateStatus(sandBoxModel);

                customProcess.WaitTillExit();
                sandBoxModel.FileStatus = FileStatus.Finished;
                UpdateStatus(sandBoxModel);
            }
            else
            {
                sandBoxModel.FileStatus = FileStatus.Error;
                UpdateStatus(sandBoxModel);
            }
            sandBoxModel.Duration = customProcess.Duration;

            HistoryRecordModel historyModel = new HistoryRecordModel()
            {
                Id = sandBoxModel.GetHashCode().ToString("x2"),
                FileName = FileHelper.GetFileNameWithoutExtension(sandBoxModel.FileInfo.Name),
                FileExtension = sandBoxModel.FileInfo.Extension,
                FilePath = FileHelper.GetPathWithoutFileName(sandBoxModel.FileInfo.FullName),
                StartupTime = sandBoxModel.TimeStamp.ToString(),
                Duration = sandBoxModel.Duration.ToString(),
                FileStatus = sandBoxModel.FileStatus.ToString()
            };

            App.Instance.MainWindowInstance.Controller.HistoryView.Controller.AddRecord(historyModel);
        }
        #endregion

        #region "Public Methods"
        public void RemoveSandBox(SandBoxModel sandBoxModel)
        {
            if (SandBoxes != null && SandBoxes.Count > 0)
            {
                SandBoxes.Remove(sandBoxModel);
            }
            sandBoxView.FilesListview.Items.RemoveByKey(sandBoxModel.GetHashCode().ToString());
        }

        public void ClearSandBoxes()
        {
            if (SandBoxes != null && SandBoxes.Count > 0)
            {
                SandBoxes.Clear();
            }
            sandBoxView.FilesListview.Items.Clear();
        }

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
                        SandBoxModel sandBox = new SandBoxModel(fileInfo, FileStatus.Ready);
                        SandBoxes.Add(sandBox);
                        AddToListView(sandBox);
                    }
                }
            }
        }

        public void Run(SandBoxModel singleSandbox = null)
        {
            List<Task> fileTasks = new List<Task>();
            //Check if the singleSandbox is not null then we will run the single sandbox.
            if (singleSandbox != null)
            {
                //Run Singular.
                fileTasks.Add(Task.Factory.StartNew(() => ExecuteSandBox(singleSandbox, SecuredDesktop.DesktopName)));
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
                        fileTasks.Add(Task.Factory.StartNew(() => ExecuteSandBox(sandBox, SecuredDesktop.DesktopName)));
                    }
                }
            }

            //If the files is greater than zero, then we can switch the screen otherwise do nothing.
            if (fileTasks.Count > 0)
            {
                //Call the method "SwitchDesktop" it will attempt to switch to the new secured desktop and returns true if it succeeded otherwise false.
                if (SecuredDesktop.SwitchDesktop())
                {
                    //Starts a new background task that will run in the threadpool.
                    Task.Factory.StartNew(async () =>
                    {
                        //Assign the desktop thread to the backround task thread, so what ever opens it will open on the new desktop.
                        if (SecuredDesktop.SetDesktopThread())
                        {
                            //Run all of the file tasks and wait for them all to be finished.
                            await Task.WhenAll(fileTasks);
                        }
                        else
                        {
                            //If the set Desktop thread failed, we will show a message.
                            MessageBoxHelpers.ErrorMessage("Could not set desktop thread", "SetDesktopThread");
                        }

                        //Here we are waiting for the task to finish.
                    }).ConfigureAwait(true).GetAwaiter().GetResult().Wait();

                    //Call the method "SwitchDesktop" it will attempt to switch to main desktop and returns true if it succeeded otherwise false.
                    if (SecuredDesktop.SwitchDesktop() == false)
                    {
                        //If the result of the SwitchDesktop returned false, show a message to the user.
                        MessageBoxHelpers.ErrorMessage("Failed to switch to the main desktop", "SwitchDesktop");
                    }

                    //Close the new desktop.
                    SecuredDesktop.CloseDesktop();

                    //Create a new desktop screen for another try.
                    SecuredDesktop.CreateDesktop();
                }
                else
                {
                    //If the result of the SwitchDesktop returned false, show a message to the user.
                    MessageBoxHelpers.ErrorMessage("Could not switch to secured desktop", "SwitchDesktop");
                }
            }
        }
        #endregion
    }
}