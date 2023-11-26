using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint5.Task7.V9.Lib;
using System.IO;

namespace Tyuiu.MedvedevA.Sprint5.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual("ello, Мир! Это s y irst rogram.", resp.LoadDataAndSave(""));
        }
    }
}
