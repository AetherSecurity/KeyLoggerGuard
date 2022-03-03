using System;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using KeyloggerEvader.Helpers;

namespace KeyloggerEvader.Utilities
{
    public class CustomProcess
    {
        #region "Fields"
        private readonly Stopwatch durationCounter;
        #endregion

        #region "Properties"
        public string FileName { get; set; }

        public int Id { get; private set; }

        public IntPtr Handle { get; private set; }

        public bool IsRunning { get; private set; }

        public TimeSpan Duration { get; private set; }
        #endregion

        public CustomProcess()
        {
            durationCounter = new Stopwatch();
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
        #endregion

        public bool Start(string desktopName = null)
        {
            if (IsRunning == false && Handle == IntPtr.Zero)
            {
                string associatedFile = null;
                string fileExtension = FileHelper.GetFileExtension(FileName);
                if (string.IsNullOrEmpty(fileExtension) == false)
                {
                    if (ResolveExtension(fileExtension, ref associatedFile))
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
                            durationCounter.Reset();
                            durationCounter.Start();
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
            else
            {
                return false;
            }
        }

        public bool Terminate()
        {
            if (IsRunning == true && Handle != IntPtr.Zero)
            {
                durationCounter.Stop();
                Duration = durationCounter.Elapsed;
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
                    durationCounter.Stop();
                    Duration = durationCounter.Elapsed;
                    IsRunning = false;
                    Handle = IntPtr.Zero;
                }
                Task.Delay(10).Wait();
            }
        }
    }
}