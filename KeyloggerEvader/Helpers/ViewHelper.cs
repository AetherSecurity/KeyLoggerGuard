using System.Reflection;
using System.Windows.Forms;

namespace KeyloggerEvader.Helpers
{
    public class ViewHelper
    {
        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
            {
                return;
            }
            PropertyInfo PropInfo = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            PropInfo.SetValue(c, true, null);
        }
    }
}