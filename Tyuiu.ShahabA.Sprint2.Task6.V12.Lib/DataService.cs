using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShahabA.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevDay = n - 1;
            int prevMonth = m;
            int prevYear = g;

            if (prevDay == 0)
            {
                prevMonth--;

                if (prevMonth == 0)
                {
                    prevMonth = 12;
                    prevYear--;
                }

                // Сокращенная форма switch
                prevDay = prevMonth switch
                {
                    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                    4 or 6 or 9 or 11 => 30,
                    2 => 29, // Високосный год
                    _ => 0
                };
            }

            return $"{prevDay}.{prevMonth}.{prevYear}";
        }

        double ISprint2Task6V12.FindDateOfPreviousDay(int g, int m, int n)
        {
            throw new NotImplementedException();
        }
    }
}