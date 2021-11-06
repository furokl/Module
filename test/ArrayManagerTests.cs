using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MainModule.Tests
{
    [TestClass]
    public class ArrayManagerTests
    {
        [TestMethod]
        public void FindMax_PositiveElements_Test()
        {
            int[] a = { 3, 6, 4, 2, 5 };
            int expected = 6;

            int actual = ArrayManager.FindMax(a);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindMax_NegativeElements_Test()
        {
            int[] a = { -3, -6, -4, -2, -5 };
            int expected = -2;

            int actual = ArrayManager.FindMax(a);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void FindMax_NullArray_ExpectedException_Test()
        {
            int[] a = null;

            int actual = ArrayManager.FindMax(a);
        }
        [TestMethod]
        public void GetAverage_Test()
        {
            int[] a = { 2, 5, 3};
            double expected = 3.33;

            double actual = ArrayManager.GetAverage(a);

            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}
