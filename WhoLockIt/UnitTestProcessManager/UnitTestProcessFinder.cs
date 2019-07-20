using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProcessManager;

namespace UnitTestProcessManager
{
    [TestClass]
    public class UnitTestProcessFinder
    {
        private string _openedFilePath = @"c:\tmp\mytext.txt";
        private string _openedDirectoryPath = @"c:\tmp\myfolder\";

        [TestMethod]
        public void TestOpenedFile()
        {
            List<string> processNames = ProcessFinder.FindLockingProcessNames(_openedFilePath);
        }

        [TestMethod]
        public void TestOpenedDirectory()
        {
        }
    }
}
