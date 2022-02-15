using System;
using System.Windows.Forms;
using KeyloggerEvader.Helpers;
using KeyloggerEvader.Controllers;
using KeyloggerEvader.Enums;
using KeyloggerEvader.Models;

namespace KeyloggerEvader.Views
{
    public partial class SandBoxView : UserControl
    {
        #region "Properties"
        public SandBoxController Controller { get; private set; }
        #endregion

        #region "Constructors & Destructor"
        public SandBoxView()
        {
            InitializeComponent();
            SetControlsDoubleBuffered();
            Controller = new SandBoxController(this);
        }

        ~SandBoxView()
        {
        }
        #endregion

        #region "View Event Handlers"
        private void OnViewLoad(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            ListviewHelper.ResizeColumn(FilesListview, FilesListview.Columns.Count - 1);
        }

        private void DragDropCardDragEnter(object sender, DragEventArgs e)
        {
            //Gets the dragged data and checks if it can be converted to a file type.
            //Returns true if the dragged data is associated with files, otherwise returns false.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //If the operation is true, then copy all of the dragged data to drop them.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void DragDropCardDragDrop(object sender, DragEventArgs e)
        {
            //Get the dragged data (files).
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //Check if the files length is not empty.
            if (files.Length > 0)
            {
                //Call the ProcessFiles method from the controller and pass the files to it.
                Controller.ProcessFiles(files);
            }
        }

        private void BrowseFileButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog BrowseFileDialog = new OpenFileDialog
            {
                Title = "Open",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "All files (*.*)|*.*|All files (*.*)|*.*",
                RestoreDirectory = true,
                Multiselect = true
            };
            if (BrowseFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Call the ProcessFiles method from the controller and pass the files to it.
                Controller.ProcessFiles(BrowseFileDialog.FileNames);
            }
        }

        private void RemoveToolStripMenuItemClick(object sender, EventArgs e)
        {
            int runningTasks = 0;
            //Loop through each selected item in the listview and remove it.
            foreach (ListViewItem selectedItem in FilesListview.SelectedItems)
            {
                //If the file status is running then we can't delete it instead we will warn the user
                //to wait till it's finished and then try to remove it.
                SandBoxModel sandBoxModel = (SandBoxModel)selectedItem.Tag;

                if (sandBoxModel.FileStatus.Equals(FileStatus.Running))
                {
                    runningTasks++;
                }
                else
                {
                    //Remove the selected item from the files listview.
                    FilesListview.Items.Remove(selectedItem);
                    //Remove the selected item from the InputFiles.
                    Controller.SandBoxes.Remove(sandBoxModel);
                }
            }
            if (runningTasks > 0)
            {
                MessageBoxHelpers.WarnMessage(string.Format("There are {0} tasks that are currently running, please wait till they are done.", runningTasks), "Remove task");
            }
        }

        private void ClearToolStripMenuItemClick(object sender, EventArgs e)
        {
            int runningTasks = 0;
            //Loop through each selected item in the listview and remove it.
            foreach (ListViewItem selectedItem in FilesListview.Items)
            {
                //If the file status is running then we can't delete it instead we will warn the user
                //to wait till it's finished and then try to remove it.
                SandBoxModel sandBoxModel = (SandBoxModel)selectedItem.Tag;

                if (sandBoxModel.FileStatus.Equals(FileStatus.Running))
                {
                    runningTasks++;
                }
                else
                {
                    //Remove the selected item from the files listview.
                    FilesListview.Items.Remove(selectedItem);
                    //Remove the selected item from the InputFiles.
                    Controller.SandBoxes.Remove(sandBoxModel);
                }
            }

            if (runningTasks > 0)
            {
                MessageBoxHelpers.WarnMessage(string.Format("There are {0} tasks that are currently running, please wait till they are done.", runningTasks), "Remove task");
            }
        }

        private void RunToolStripMenuItemClick(object sender, EventArgs e)
        {
            //Loop through each selected item in the listview and remove it.
            foreach (ListViewItem selectedItem in FilesListview.SelectedItems)
            {
                //If the file status is running then we can't run it instead we will warn the user
                //to wait till it's finished and then try to run it again.
                SandBoxModel sandBoxModel = (SandBoxModel)selectedItem.Tag;
                if (sandBoxModel.FileStatus.Equals(FileStatus.Running))
                {
                    MessageBoxHelpers.WarnMessage("Cannot run the file. It is already running.", "Run File");
                }
                else
                {
                    Controller.Run(sandBoxModel);
                }
            }
        }

        private void RunButtonClick(object sender, EventArgs e)
        {
            //Execute all of the files.
            Controller.Run();
        }
        #endregion

        #region "View Overrided Methods"
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        #region "Private Methods"
        private void SetControlsDoubleBuffered()
        {
            foreach (Control Ctrl in Controls)
            {
                ViewHelper.SetDoubleBuffered(Ctrl);
                foreach (Control CtrlChild in Ctrl.Controls)
                {
                    ViewHelper.SetDoubleBuffered(CtrlChild);
                }
            }
        }
        #endregion
    }
}