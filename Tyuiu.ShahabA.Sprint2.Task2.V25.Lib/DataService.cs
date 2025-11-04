using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShahabA.Sprint2.Task2.V25.Lib
{
    public class DataService :ISprint2Task2V25
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool result = false;

            // Основная область - большой прямоугольник
            if ((x >= 3 && x <= 5) && (y >= 3 && y <= 7))
            {
                result = true;
            }
            // Правая область
            else if ((x >= 6 && x <= 7) && (y >= 4 && y <= 5))
            {
                result = true;
            }
            // Нижняя область
            else if ((x >= 8 && x <= 9) && (y >= 3 && y <= 4))
            {
                result = true;
            }
            // Левая область
            else if ((x >= 10 && x <= 12) && (y >= 3 && y <= 7))
            {
                result = true;
            }
            // Верхняя область
            else if ((x >= 9 && x <= 11) && (y >= 5 && y <= 6))
            {
                result = true;
            }

            return result;
        }
    }
}