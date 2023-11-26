using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint5.Task5.V4.Lib;
using System.IO;

namespace Tyuiu.MedvedevA.Sprint5.Task5.V4.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadFromDataFile()
        {

            string path = @"C:\DataSprint5\InPutDataFileTask5V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
