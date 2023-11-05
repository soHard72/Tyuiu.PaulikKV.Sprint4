using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint4.Task2.V30.Lib;

namespace Tyuiu.PaulikKV.Sprint4.Task2.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Паулик К.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 12 элементов заполненный*");
            Console.WriteLine("* случайными в диапазоне от 2 до 8 подсчитать произведение нечетных       *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.Write("Введите кол-во элементов массива ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] numsarray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {

                numsarray[i] = rnd.Next(2, 8);
            }

            Console.WriteLine("Массив :");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsarray[i] + "\t");
            }
            Console.WriteLine();

            int res = ds.Calculate(numsarray);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение нечетных элементов = " + res);
            Console.ReadKey();
        }
    }
}
