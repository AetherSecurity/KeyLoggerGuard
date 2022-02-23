using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace KeyloggerEvader.Utilities
{
    public class CustomProcess
    {
        #region "Properties"
        public string FileName { get; set; }

        public int Id { get; private set; }

        public IntPtr Handle { get; private set; }

        public bool IsRunning { get; private set; }
        #endregion

        public CustomProcess()
        {
            FileName = string.Empty;
            Handle = IntPtr.Zero;
            IsRunning = false;
        }

        #region "Private Methods"
        private bool ResolveExtension(string fileExtension, ref string associatedFile)
        {
            uint length = 0;
            uint result = WinAPI.AssocQueryString(WinAPI.AssocF.None, WinAPI.AssocStr.Executable, fileExtension, null, null, ref length);
            if (result == 1)
            {
                StringBuilder value = new StringBuilder((int)length);
                result = WinAPI.AssocQueryString(WinAPI.AssocF.None, WinAPI.AssocStr.Executable, fileExtension, null, value, ref length);
                if (result == 0)
                {
                    associatedFile = value.ToString();
                    return true;
                }
            }
            return false;
        }

        private string GetFileExtension()
        {
            if (string.IsNullOrEmpty(FileName) == false)
            {
                try
                {
                    return Path.GetExtension(FileName);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return null;
            }
        }
        #endregion

        public bool Start(string desktopName = null)
        {
            if (IsRunning == false && Handle == IntPtr.Zero)
            {
                string associatedFile = null;
                if (ResolveExtension(GetFileExtension(), ref associatedFile))
                {
                    string command = string.Format("\"{0}\" \"{1}\"", associatedFile, FileName);
                    WinAPI.STARTUPINFO startupInfo = new WinAPI.STARTUPINFO
                    {
                        lpDesktop = desktopName
                    };
                    WinAPI.PROCESS_INFORMATION processInfo = new WinAPI.PROCESS_INFORMATION();
                    bool result = WinAPI.CreateProcess(null, command, IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref startupInfo, out processInfo);
                    if (result == true)
                    {
                        Id = (int)processInfo.dwProcessId;
                        Handle = processInfo.hProcess;
                        IsRunning = true;
                        return true;
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
            else
            {
                return false;
            }
        }

        public bool Terminate()
        {
            if (IsRunning == true && Handle != IntPtr.Zero)
            {
                return WinAPI.TerminateProcess(Handle, 0);
            }
            else
            {
                return false;
            }
        }

        public void WaitTillExit()
        {
            while (IsRunning == true && Handle != IntPtr.Zero)
            {
                if (WinAPI.GetExitCodeProcess(Handle, out uint exitCode) == false || exitCode != 259)
                {
                    IsRunning = false;
                    Handle = IntPtr.Zero;
                }
                Task.Delay(10).Wait();
            }
        }
    }
}