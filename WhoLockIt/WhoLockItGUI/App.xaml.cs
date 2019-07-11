using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using ProcessLibrary;

namespace WhoLockItGUI
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // コマンドライン引数が指定されていない場合
            if (e.Args.Length == 0)
            {
                MessageBox.Show(
                    "このexeファイルに、何か別のファイルまたはフォルダをドラッグ＆ドロップしてください。",
                    "お願い"
                    );
                Current.Shutdown(1);
                return;
            }

            List<string> fileList = ArgsToFileList(e.Args);

            MyDebugger.DumpList(fileList);

            List<FileProcess> fileProcessList = null;
            fileProcessList = GetFileProcessList(fileList);

            // どのファイルもロックされていない場合
            if (fileProcessList == null)
            {
                MessageBox.Show(
                    "ロックされているファイルはありませんでした！",
                    "ロックされていません"
                    );
                Current.Shutdown(0);
                return;
            }

            MyDebugger.DumpList(fileProcessList);

            MainWindow win = new MainWindow(fileProcessList);
            win.ShowDialog();

            Current.Shutdown(0);
        }

        private List<FileProcess> GetFileProcessList(List<string> fileList)
        {
            List<FileProcess> output = new List<FileProcess>();
            bool lockedFileExist = false;

            foreach (string filePath in fileList)
            {
                List<Process> processList = Win32Processes.GetProcessesLockingFile(filePath);
                if (processList != null && processList.Count > 0)
                {
                    output.Add(
                        new FileProcess() { FilePath = filePath, ProcessName = processList[0].ProcessName }
                        );
                    lockedFileExist = true;
                }
            }

            return lockedFileExist ? output : null;
        }

        private List<string> ArgsToFileList(string[] args)
        {
            List<string> output = new List<string>();

            foreach (string arg in args)
            {
                if (File.Exists(arg))
                {
                    output.Add(arg);
                }
                else if (Directory.Exists(arg + "\\"))
                {
                    output.AddRange(GetFileListRecursively(arg));
                }
            }

            return output;
        }

        private List<string> GetFileListRecursively(string dirPath)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(dirPath, "*", SearchOption.AllDirectories);
            if (files == null) return null;
            return new List<string>(files);
        }
    }
}
