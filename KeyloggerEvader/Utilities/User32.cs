using System;
using System.Runtime.InteropServices;

namespace KeyloggerEvader.Utilities
{
    public class User32
    {
        #region "Constants"
        public const int Autohide = 0x0000001;
        public const int AlwaysOnTop = 0x0000002;
        #endregion

        #region "Enums"
        public enum ABS
        {
            AutoHide = 0x01,
            AlwaysOnTop = 0x02,
        }

        public enum AppBarEdge : uint
        {
            Left = 0,
            Top = 1,
            Right = 2,
            Bottom = 3
        }

        public enum AppBarMessage : uint
        {
            New = 0x00000000,
            Remove = 0x00000001,
            QueryPos = 0x00000002,
            SetPos = 0x00000003,
            GetState = 0x00000004,
            GetTaskbarPos = 0x00000005,
            Activate = 0x00000006,
            GetAutoHideBar = 0x00000007,
            SetAutoHideBar = 0x00000008,
            WindowPosChanged = 0x00000009,
            SetState = 0x0000000A,
        }
        #endregion

        #region "Structures"
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public uint dwProcessId;
            public uint dwThreadId;
        }

        public struct STARTUPINFO
        {
            public uint cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct APPBARDATA
        {
            public uint cbSize;
            public IntPtr hWnd;
            public uint uCallbackMessage;
            public AppBarEdge uEdge;
            public RECT rc;
            public int lParam;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        #endregion

        #region "Windows API"
        /// <summary>
        /// Creates a new desktop screen.
        /// </summary>
        [DllImport("user32.dll")]
        public static extern IntPtr CreateDesktop(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, int dwFlags, uint dwDesiredAccess, IntPtr lpsa);

        /// <summary>
        /// Switches to another desktop screen if found.
        /// </summary>
        [DllImport("user32.dll")]
        private static extern bool SwitchDesktop(IntPtr hDesktop);

        /// <summary>
        /// Closes a specific desktop screen
        /// </summary>
        [DllImport("user32.dll")]
        public static extern bool CloseDesktop(IntPtr handle);

        /// <summary>
        /// Sets the current thread to the desktop thread.
        /// </summary>
        [DllImport("user32.dll")]
        public static extern bool SetThreadDesktop(IntPtr hDesktop);

        /// <summary>
        /// Gets the desktop screen thread.
        /// </summary>
        /// <param name="dwThreadId"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetThreadDesktop(int dwThreadId);

        /// <summary>
        /// Gets the current thread that our application is running on.
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern int GetCurrentThreadId();

        /// <summary>
        /// Creates a process.
        /// </summary>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

        /// <summary>
        /// Termintes a running process.
        /// </summary>
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);

        /// <summary>
        /// Gets the termination status of a process.
        /// </summary>
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetExitCodeProcess(IntPtr hProcess, out uint lpExitCode);

        /// <summary>
        /// Retrieves the handle of the top-level window.
        /// </summary>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// Sends an appbar message to the system.
        /// </summary>
        [DllImport("shell32.dll", SetLastError = true)]
        public static extern IntPtr SHAppBarMessage(AppBarMessage dwMessage, [In] ref APPBARDATA pData);
        #endregion
    }
}