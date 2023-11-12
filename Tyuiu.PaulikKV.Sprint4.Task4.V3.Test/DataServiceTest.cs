using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint4.Task4.V3.Lib;

namespace Tyuiu.PaulikKV.Sprint4.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 7, 9, 7, 8, 6 },
                                          { 4, 4, 4, 8, 6 },
                                          { 7, 9, 6, 7, 6 },
                                          { 7, 5, 4, 9, 8 },
                                          { 9, 6, 4, 9, 8} };
            int res = ds.Calculate(matrix);
            int wait = 85;

            Assert.AreEqual(wait, res);
        }
    }
}
