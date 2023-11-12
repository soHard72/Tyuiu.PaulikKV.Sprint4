using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprit4.Task6.V6.Lib;

namespace Tyuiu.PaulikKV.Sprit4.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
           

            Console.Title = "Спринт #4 | Выполнил: Паулик К.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан строковый массив данных [Борис, Анна, Михаил, Ирина,       *");
            Console.WriteLine("* Сергей, Татьяна, Олег], используя класс Array, выведите элементы        *");
            Console.WriteLine("* массива, длина которых равна 5 символам                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var names = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            string[] res = ds.Calculate(names);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Элементы массива, длина которых равна 5 символам: ");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
