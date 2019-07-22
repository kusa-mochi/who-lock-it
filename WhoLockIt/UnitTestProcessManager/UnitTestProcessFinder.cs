using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProcessManagerCLR;

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
            ProcessFinderCLR f = new ProcessFinderCLR();
            f.FuncA();
        }

        [TestMethod]
        public void TestOpenedDirectory()
        {
        }
    }
}
