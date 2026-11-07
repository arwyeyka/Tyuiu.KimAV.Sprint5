using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KimAV.Sprint5.Task0.V6.Lib;
namespace Tyuiu.KimAV.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\User\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = File.Exists(path);
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
