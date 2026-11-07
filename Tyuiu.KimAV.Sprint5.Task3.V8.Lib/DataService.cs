using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KimAV.Sprint5.Task3.V8.Lib
{
    public class DataService : ISprint5Task3V8
    {
        public string SaveToFileTextData(int x)
        {
            string getPath = Path.GetTempPath();
            string path = Path.Combine(getPath, "OutPutFileTask3.bin");
            double y = (Math.Pow(x, 2) + 1) / (3 * x + 4);
            y = Math.Round(y, 3);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = File.Exists(path);
            if (fileExists)
            {
                File.Delete(path);
            }
            using (BinaryWriter writter = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), System.Text.Encoding.UTF8))
            {
                writter.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
