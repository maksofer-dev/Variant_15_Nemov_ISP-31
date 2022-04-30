using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Variant_15;

namespace TestProject
{
    [TestClass]
    public class NegativeCountTest
    {
        [TestMethod]
        public void NegativeCountTst()
        {
            int[,] array = new int[8, 8]
            {
                {2 , 5, 10, 31, -2, 0, 54, 12},
                {4, 13, 10, 0, 3, 81, 10, 51},
                {91, 4, 83, 31, 4, 73, 0, 10 },
                {-1, 5, 8, 13, 75, 10, 1, 84 },
                {-4, 54, 81, 12, 45, 34, 15, 34 },
                {3, 4, 1, 65, 43, 56, 34, 12 },
                {13, 43, 57, 81, 31, 3, 1, 24 },
                {9, 51, 43, 8, 1, 4, 7, 2 }
            };
            int expected = 3;
            NegativeSumRows negat = new NegativeSumRows();
            int actual = negat.NegativeSum(array);
            
            Assert.AreEqual(expected, actual, "Количество отрицательных строк не совпадает");
            

        }
    }
}
