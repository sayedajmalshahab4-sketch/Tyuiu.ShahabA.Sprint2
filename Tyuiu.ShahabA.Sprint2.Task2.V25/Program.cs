using System;
using Tyuiu.ShahabA.Sprint2.Task2.V25.Lib;

namespace Tyuiu.ShahabA.Sprint2.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            Console.Write("Введите координату X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("*************************");

            bool inArea = ds.CheckDotInShadedArea(x, y);

            if (inArea)
            {
                Console.WriteLine($"Точка ({x}, {y}) находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка ({x}, {y}) НЕ находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}