using System;
namespace KeyloggerEvader
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Will be initialized only in the main, and one time only.
            new App();
        }
    }
}