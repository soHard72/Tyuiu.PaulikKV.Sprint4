using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint4.Task5.V29.Lib;

namespace Tyuiu.PaulikKV.Sprint4.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -7, 9, 7, -1, 6 },
                                          { 2, 5, 4, 8, -4 },
                                          { -7, 9, 6, -5, 6 },
                                          { 2, -5, 1, -9, 8 },
                                          { -9, 6, 3, 9, 3} };
            int res = ds.Calculate(matrix);
            int wait = 17;

            Assert.AreEqual(wait, res);
        }
    }
}
