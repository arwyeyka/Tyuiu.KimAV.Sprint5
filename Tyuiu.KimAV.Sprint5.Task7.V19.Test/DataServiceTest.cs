using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KimAV.Sprint5.Task7.V19.Lib;
namespace Tyuiu.KimAV.Sprint5.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheck()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint7\InPutDataFileTask7V19.txt";
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint7\InPutDataFileTask7V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
