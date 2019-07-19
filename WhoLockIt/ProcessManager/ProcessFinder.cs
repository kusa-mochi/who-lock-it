using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation; // Win10 SDK is required.
using System.Text;
using System.Threading.Tasks;

namespace ProcessManager
{
    public static class ProcessFinder
    {
        private static string _command = ""
            + "Function FindLockingProcess"
            + "{"
                + "Param"
                + "("
                    + "[Parameter(Mandatory=$true)]"
                    + "[String] $FileOrFolderPath"
                + ")"
                + "IF((Test-Path -Path $FileOrFolderPath) -eq $false) {"
                    + "Write-Warning \"File or directory does not exist.\""
                + "}"
                + "Else {"
                    + "$LockingProcess = CMD /C \"openfiles /query /fo table | find /I \"\"$FileOrFolderPath\"\"\""
                    + "Write-Host $LockingProcess"
                + "}"
            + "}";

        public static List<string> FindLockingProcessNames(string fileOrFolderPath)
        {
            List<string> output = new List<string>();

            using (var invoker = new RunspaceInvoke())
            {
                var result = invoker.Invoke(_command, new[] { fileOrFolderPath });
                foreach (var r in result)
                {
                }
            }

            return output;
        }
    }
}
