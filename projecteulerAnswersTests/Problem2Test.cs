using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projecteulerAnswers;

namespace projecteulerAnswersTests
{
    [TestClass]
    public class Problem2Test
    {
        [TestMethod]
        public void GetFabValueOfIndex()
        {
            var expected = 8UL;
            var actual = Problem2.GetFabValueOfIndex(6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFabValueOf()
        {
            var expected = 8L;
            var actual = Problem2.GetFabValueOf(6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsAFiboNacci()
        {
            var condition = Problem2.IsAFiboNacci(21);
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void GetEvenTermSumOfFibonacciIn()
        {
            var expected = 44UL;
            var actual = Problem2.GetEvenTermSumOfFibonacciIn(34);
            Assert.AreEqual(expected, actual);
        }
    }
}
