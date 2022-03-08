using System;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using KeyloggerEvader.Helpers;
using System.IO;

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

        /*
            if (fileExtension.Equals(".exe"))
            {
                string command = string.Format("\"{0}\"", FileName);
                WinAPI.STARTUPINFO startupInfo = new WinAPI.STARTUPINFO
                {
                    lpDesktop = desktopName
                };
                startupInfo.dwFlags |= 0x00000020;

                WinAPI.PROCESS_INFORMATION processInfo = new WinAPI.PROCESS_INFORMATION();

                bool result = WinAPI.CreateProcess(command, command, IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref startupInfo, out processInfo);
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
            else if (ResolveExtension(fileExtension, ref associatedFile))
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
         */
        public bool Start(string desktopName = null)
        {
            if (IsRunning == false && Handle == IntPtr.Zero)
            {
                string fileExtension = FileHelper.GetFileExtension(FileName);
                string procline = string.Format("\"{0}\"", FileName);
                Debug.WriteLine("ProcLine: " + procline);
                int i;
                for (i = 0; i < 10; i++)
                {
                    if (fileExtension == ".dll")
                    {
                        procline = string.Format("{0} {1}", @"rundll32", procline);
                        break;
                    }
                    else if (fileExtension != ".exe")
                    {
                        string file = "";
                        if (!ResolveExtension(fileExtension, ref file))
                        {
                            break;
                        }
                        procline = string.Format("\"{0}\" {1}", file, procline);
                        fileExtension = Path.GetExtension(file).ToLower();
                        //fileExtension = FileHelper.GetFileExtension(file).ToLower();
                    }
                    else
                    {
                        break;
                    }
                }
                if (i == 10)
                {
                    Console.WriteLine("Could not locate default program");
                    return false;
                }

                try
                {
                    WinAPI.STARTUPINFO startupInfo = new WinAPI.STARTUPINFO();
                    startupInfo.lpDesktop = desktopName;
                    startupInfo.dwFlags |= 0x00000020;
                    WinAPI.PROCESS_INFORMATION processInfo = new WinAPI.PROCESS_INFORMATION();
                    bool result = WinAPI.CreateProcess(null, procline, IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref startupInfo, out processInfo);
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
                catch (Exception ex)
                {
                    Console.WriteLine("Exception at Start(): {0}", ex.Message);
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