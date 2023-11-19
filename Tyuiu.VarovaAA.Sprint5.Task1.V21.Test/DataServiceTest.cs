using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.VarovaAA.Sprint5.Task1.V21.Lib;
namespace Tyuiu.VarovaAA.Sprint5.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.VarovaAA.Sprint5\Tyuiu.VarovaAA.Sprint5.Task1.V21\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
