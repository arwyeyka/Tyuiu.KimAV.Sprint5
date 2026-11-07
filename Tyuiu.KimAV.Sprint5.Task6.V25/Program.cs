using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KimAV.Sprint5.Task6.V25.Lib;
namespace Tyuiu.KimAV.Sprint5.Task6.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Ким А.В. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Ким Артём Владимирович | ИИПб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти количество знаков восклицания в заданной строке.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint6\InPutDataFileTask6V25.txt";
            Console.WriteLine($"Данные находятся в файле: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Ответ равен => {res}");
            Console.ReadKey();
        }
    }
}
