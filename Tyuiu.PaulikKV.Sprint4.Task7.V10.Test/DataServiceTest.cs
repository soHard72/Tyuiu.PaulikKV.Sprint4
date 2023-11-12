using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint4.Task7.V10.Lib;

namespace Tyuiu.PaulikKV.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 4;
            int[,] matrix = new int[rows, columns];
            string str = "695847142536";
            int res = ds.Calculate(rows, columns, str);
            int wait = 30;
            Assert.AreEqual(wait,res);
        }
    }
}
