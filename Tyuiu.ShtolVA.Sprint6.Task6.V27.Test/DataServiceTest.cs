using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShtolVA.Sprint6.Task6.V27.Lib;


namespace Tyuiu.ShtolVA.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\Users\vikto\source\repos\Tyuiu.ShtolVA.Sprint6\Tyuiu.ShtolVA.Sprint6.Task6.V27\bin\Debug\InPutFileTask6V27.txt";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
            
        }
    }
}
