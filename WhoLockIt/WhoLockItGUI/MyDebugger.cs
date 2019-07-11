using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WhoLockItGUI
{
    static public class MyDebugger
    {
        static public void DumpList(IEnumerable<string> list)
        {
            if (list == null)
            {
                MessageBox.Show("list is null.");
                return;
            }

            string mes = "";

            foreach (string item in list)
            {
                mes += item + "\n";
            }

            MessageBox.Show(mes);
        }

        static public void DumpList(IEnumerable<FileProcess> list)
        {
            if (list == null)
            {
                MessageBox.Show("list is null.");
                return;
            }

            string mes = "";

            foreach (FileProcess item in list)
            {
                mes += "file: " + item.FilePath + ", process: " + item.ProcessName + "\n";
            }

            MessageBox.Show(mes);
        }
    }
}
