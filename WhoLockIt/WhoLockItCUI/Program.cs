using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using ProcessLibrary;

namespace WhoLockItCUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int nArgs = args.Length;
            if (nArgs == 0)
            {
                MessageBox.Show(
                    "このexeファイルに、何か別のファイルをドラッグ＆ドロップしてください。",
                    "お願い"
                    );
                return;
            }

            List<Process> processList = Win32Processes.GetProcessesLockingFile(args[0]);

            if(processList.Count > 0)
            {
                string processName = processList[0].ProcessName;
                MessageBox.Show(
                    "\"" + args[0] + "\"\n\nは現在、\n\n\"" + processName + "\"\n\nによってロックされています。",
                    "ロックされています"
                    );
            }
            else
            {
                MessageBox.Show(
                    "\"" + args[0] + "\"\n\nをロックしているプログラムはありません。",
                    "ロックされていません"
                    );
            }
        }
    }
}
