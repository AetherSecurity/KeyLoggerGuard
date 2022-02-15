using System;

namespace KeyloggerEvader.Services
{
    public interface ISecuredDesktopService
    {
        IntPtr MainDesktopId { get; }

        IntPtr NewDesktopId { get; }

        void Initialize();

        void CreateDesktop();

        void SwitchDesktop();

        void CloseDesktop();
    }
}