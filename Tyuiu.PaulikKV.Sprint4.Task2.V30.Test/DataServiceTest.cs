using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint4.Task2.V30.Lib;

namespace Tyuiu.PaulikKV.Sprint4.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 12, 11 };
            int res = ds.Calculate(numsArray);
            int wait = 33;

            Assert.AreEqual(wait,res);
        }
    }
}
