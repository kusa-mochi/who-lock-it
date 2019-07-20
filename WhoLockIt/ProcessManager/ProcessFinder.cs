using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManager
{
    public static class ProcessFinder
    {
        [DllImport("kernel32.dll")]
        private static extern bool GetProcessInformation(
            IntPtr hProcess, 
            ProcessInformationClass processInformationClass, 
            IntPtr processInformation, 
            uint processInformationSize
            );

        public static List<string> FindLockingProcessNames(string fileOrFolderPath)
        {
            List<string> output = new List<string>();

            return output;
        }
    }
}
