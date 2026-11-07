using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KimAV.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double sumEven = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var numbers = line.Split(',')
                                      .Select(s => s.Trim())
                                      .Where(s => !string.IsNullOrEmpty(s))
                                      .Select(s => int.Parse(s))
                                      .ToArray();
                    sumEven = numbers.Where(n => n % 2 == 0).Sum();
                }
            }
            return Math.Round(sumEven, 3);
        }
    }
}
