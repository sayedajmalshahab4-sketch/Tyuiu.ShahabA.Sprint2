using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShahabA.Sprint2.Task7.V1.Lib
{
    public class DataService :ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверка нахождения точки между линиями y = x и y = -x
            // в области где |y| <= |x|
            bool result = (y <= Math.Abs(x)) && (y >= -Math.Abs(x));

            return result;
        }
    }
}