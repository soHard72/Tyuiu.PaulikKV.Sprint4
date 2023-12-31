﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprit4.Task6.V6.Lib;

namespace Tyuiu.PaulikKV.Sprit4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] names = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] res = ds.Calculate(names);
            string[] wait = {"Борис","Ирина"};

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
