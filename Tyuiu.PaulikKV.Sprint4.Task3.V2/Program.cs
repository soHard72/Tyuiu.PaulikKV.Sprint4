using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint4.Task3.V2.Lib;

namespace Tyuiu.PaulikKV.Sprint4.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 4, 3, 2, 8, 7 },
                                          { 4, 6, 5, 5, 7 },
                                          { 3, 8, 8, 3, 5 },
                                          { 5, 7, 5, 4, 4 },
                                          { 8, 8, 3, 7, 6 } };
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;


            Console.Title = "Спринт #4 | Выполнил: Паулик К.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 5 на 5 элементов,          *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 2 до 8.              *");
            Console.WriteLine("* Найдите максимальный элемент в первой строке массива.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i,j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int res = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Максимальный элемент первой строки = " + res);
            Console.ReadKey();
        }
    }
}
