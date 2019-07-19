using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProcessLibrary;

namespace UnitTestProcessLibrary
{
    [TestClass]
    public class UnitTestWin32Processes
    {
        private string _openedFilePath = @"c:\tmp\mytext.txt";
        private string _openedDirectoryPath = @"c:\tmp\myfolder\";

        /// <summary>
        /// このテストを実行する前に，
        /// c:\tmp\mytext.txt
        /// を何かしらのプログラムで開かれた状態にしておくこと。
        /// </summary>
        [TestMethod]
        public void TestOpenedFile()
        {
            List<Process> processes = Win32Processes.GetProcessesLockingFile(_openedFilePath);
            Assert.IsNotNull(processes);
            Assert.AreNotEqual(0, processes.Count);
        }

        /// <summary>
        /// このテストを実行する前に，
        /// c:\tmp\myfolder\
        /// をコマンドプロンプトで開かれた状態にしておくこと。
        /// </summary>
        [TestMethod]
        public void TestOpenedDirectory()
        {
            List<Process> processes = Win32Processes.GetProcessesLockingFile(_openedDirectoryPath);
            Assert.IsNotNull(processes);
            Assert.AreNotEqual(0, processes.Count);
        }
    }
}
