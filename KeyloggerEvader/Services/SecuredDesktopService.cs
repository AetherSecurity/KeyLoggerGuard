using KeyloggerEvader.Utilities;
using System;

namespace KeyloggerEvader.Services
{
    public class SecuredDesktopService : ISecuredDesktopService
    {
        public IntPtr MainDesktopId { get; private set; }

        public IntPtr NewDesktopId { get; private set; }

        public void Initialize()
        {
            MainDesktopId = User32.GetThreadDesktop(User32.GetCurrentThreadId());
        }

        public void CreateDesktop()
        {
        }

        public void SwitchDesktop()
        {

        }

        public void CloseDesktop()
        {
        }
    }
}