using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VarovaAA.Sprint5.Task3.V12.Lib
{
    public class DataService : ISprint5Task3V12
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double z = Math.Pow((double)x, 3) / (2 * Math.Pow((double)x + 5, 2));

            z = Math.Round(z, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }

            return path;
        }
    }
}
