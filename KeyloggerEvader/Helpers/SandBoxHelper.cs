using KeyloggerEvader.Models;
using KeyloggerEvader.Utilities;

namespace KeyloggerEvader.Helpers
{
    public class SandBoxHelper
    {
        public static void ExecuteSandBox(SandBoxModel sandBoxModel, string desktopName)
        {
            CustomProcess customProcess = new CustomProcess()
            {
                FileName = sandBoxModel.FileInfo.FullName
            };

            if (customProcess.Start(desktopName))
            {
                sandBoxModel.FileStatus = Enums.FileStatus.Running;

                customProcess.WaitTillExit();
                sandBoxModel.FileStatus = Enums.FileStatus.Finished;
            }
            else
            {
                sandBoxModel.FileStatus = Enums.FileStatus.Error;
            }
        }
    }
}