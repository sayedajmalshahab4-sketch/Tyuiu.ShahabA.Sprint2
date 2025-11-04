using System;

namespace Tyuiu.ShahabA.Sprint2.Task2.V6.Lib
{
    public class DataService
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}