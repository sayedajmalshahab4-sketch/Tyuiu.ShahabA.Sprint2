using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint2.Task7.V1.Lib;

namespace Tyuiu.ShahabA.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            bool wait = true;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotNotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            bool wait = false;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}