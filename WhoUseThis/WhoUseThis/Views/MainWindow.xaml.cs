using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using ProcessLibrary;

namespace WhoUseThis.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string filePath = @"C:\src\github\who-use-this\README.md";
            List<Process> processList = Win32Processes.GetProcessesLockingFile(filePath);
            foreach(Process p in processList)
            {
                MessageBox.Show(p.ProcessName);
            }
        }
    }
}
