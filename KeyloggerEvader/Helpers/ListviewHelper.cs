using System.Windows.Forms;
using MaterialSkin.Controls;

namespace KeyloggerEvader.Helpers
{
    public class ListviewHelper
    {
        public static void ResizeColumn(MaterialListView Listview, int Index)
        {
            Listview.Columns[Index].Width = -2;
        }

        public static void ResizeColumns(MaterialListView Listview)
        {
            foreach (ColumnHeader Column in Listview.Columns)
            {
                Column.Width = -2;
            }
        }
    }
}