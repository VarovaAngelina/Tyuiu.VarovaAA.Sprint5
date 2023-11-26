using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.VarovaAA.Sprint5.Task6.V11.Lib;
namespace Tyuiu.VarovaAA.Sprint5.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.VarovaAA.Sprint5\Tyuiu.VarovaAA.Sprint5.Task6.V11\bin\Debug\InPutFileTask6.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.VarovaAA.Sprint5\Tyuiu.VarovaAA.Sprint5.Task6.V11\bin\Debug\InPutFileTask6.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
