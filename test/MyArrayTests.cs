using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MainModule.Tests
{
    [TestClass]
    public class MyArrayTests
    {
        MyArray array;

        [TestInitialize]
        public void Setup()
        {
            int[] a = { 4, 6, 8, 10, 12 };
            array = new MyArray(a);
        }
        [TestMethod]
        public void FindMax_Test()
        {
            int expected = 12;

            int actual = array.FindMax();

            Assert.AreEqual(expected, actual);
        }
    }
}
