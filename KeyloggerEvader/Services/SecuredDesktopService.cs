using System;
using KeyloggerEvader.Utilities;

namespace KeyloggerEvader.Services
{
    public class SecuredDesktopService : ISecuredDesktopService
    {
        #region "Fields"
        private bool isSwitched = false;
        #endregion

        public string DesktopName { get; private set; }

        public IntPtr MainDesktopId { get; private set; }

        public IntPtr NewDesktopId { get; private set; }

        public void Initialize()
        {
            DesktopName = "SecuredDesktop";
            //To get the address of the main desktop.
            MainDesktopId = WinAPI.GetThreadDesktop(WinAPI.GetCurrentThreadId());

            //Create a new secured desktop.
            CreateDesktop();
        }

        public void CreateDesktop()
        {
            NewDesktopId = WinAPI.CreateDesktop(DesktopName, IntPtr.Zero, IntPtr.Zero, 0, (uint)WinAPI.DESKTOP_ACCESS.CUSTOM_SECURE, IntPtr.Zero);
        }

        public bool SwitchDesktop()
        {
            IntPtr Source = isSwitched ? MainDesktopId : NewDesktopId;
            if (WinAPI.SwitchDesktop(Source))
            {
                isSwitched = !isSwitched;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetDesktopThread()
        {
            if (NewDesktopId != IntPtr.Zero)
            {
                return WinAPI.SetThreadDesktop(NewDesktopId);
            }
            else
            {
                return false;
            }
        }

        public bool CloseDesktop()
        {
            if (NewDesktopId != IntPtr.Zero)
            {
                bool closeReuslt = WinAPI.CloseDesktop(NewDesktopId);
                NewDesktopId = IntPtr.Zero;
                return closeReuslt;
            }
            else
            {
                return false;
            }
        }
    }
}