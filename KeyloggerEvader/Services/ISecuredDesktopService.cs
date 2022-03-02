using System;

namespace KeyloggerEvader.Services
{
    public interface ISecuredDesktopService
    {
         string DesktopName { get; }

         IntPtr MainDesktopId { get; }

         IntPtr NewDesktopId { get; }

         void Initialize();

         void CreateDesktop();

         bool SwitchDesktop();


        bool SetDesktopThread();

        bool CloseDesktop();
    }
}