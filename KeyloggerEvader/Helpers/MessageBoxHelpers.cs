using System.Windows.Forms;

namespace KeyloggerEvader.Helpers
{
    public class MessageBoxHelpers
    {
        public static void ErrorMessage(string Message, string Title)
        {
            MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorMessage(string Message, string Title, MessageBoxButtons Buttons)
        {
            MessageBox.Show(Message, Title, Buttons, MessageBoxIcon.Error);
        }

        public static void InfoMessage(string Message, string Title)
        {
            MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void InfoMessage(string Message, string Title, MessageBoxButtons Buttons)
        {
            MessageBox.Show(Message, Title, Buttons, MessageBoxIcon.Information);
        }

        public static void WarnMessage(string Message, string Title)
        {
            MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void WarnMessage(string Message, string Title, MessageBoxButtons Buttons)
        {
            MessageBox.Show(Message, Title, Buttons, MessageBoxIcon.Warning);
        }
    }
}