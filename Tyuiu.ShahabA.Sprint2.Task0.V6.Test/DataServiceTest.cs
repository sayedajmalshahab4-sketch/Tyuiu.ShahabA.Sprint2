using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint2.Task0.V6.Lib;

namespace Tyuiu.ShahabAJ.Sprint2.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 107;
            int y = 754;
            bool[] wait = { true, true, true, false, true, false };
            bool[] result = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}