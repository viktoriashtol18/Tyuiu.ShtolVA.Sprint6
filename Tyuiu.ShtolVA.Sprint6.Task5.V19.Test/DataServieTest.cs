using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShtolVA.Sprint6.Task5.V19.Lib;

namespace Tyuiu.ShtolVA.Sprint6.Task5.V19.Test
{
    [TestClass]
    public class DataServieTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\vikto\source\repos\Tyuiu.ShtolVA.Sprint6\Tyuiu.ShtolVA.Sprint6.Task5.V19\bin\Debug\InPutFileTask5V19.txt";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
            
        }
    }
}
