using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint5.Task0.V12.Lib;
using System.IO;

namespace Tyuiu.MedvedevA.Sprint5.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\D1BOO.\source\repos\Tyuiu.MedvedevA.Sprint5\Tyuiu.MedvedevA.Sprint5.Task0.V12\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool tyta = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, tyta);
        }
    }
}
