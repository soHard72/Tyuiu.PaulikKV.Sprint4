using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint4.Task1.V29.Lib;

namespace Tyuiu.PaulikKV.Sprint4.Task1.V28
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 14 элементов заполненный*");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 6 подсчитать произведение   *");
            Console.WriteLine("*  нечетных элементов массива. С клавиатуры: 2,4,4,5,3,4,4,6,2,4,5,5,4,4  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.Write("Введите кол-во элементов массива ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] numsarray = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива = ");
                numsarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив :");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsarray[i] + "\t");
            }
            Console.WriteLine();
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
