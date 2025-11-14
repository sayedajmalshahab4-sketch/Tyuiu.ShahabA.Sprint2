using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint2.Task4.V28.Lib;

namespace Tyuiu.ShahabA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 10;
            // x < y*2 - 10 → 2 < 20-10 → 2 < 10 → True
            // z = (1 + (10+2)/4)^2 = (1 + 12/4)^2 = (1 + 3)^2 = 16
            double wait = 16.0;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            // x < y*2 - 10 → 10 < 10-10 → 10 < 0 → False
            // z = (2*100 - cos(5)² + 12) / (25 - sin(10)² + 9)
            double wait = 1.923;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result, 0.001);
        }
    }
}