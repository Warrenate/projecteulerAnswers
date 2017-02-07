using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projecteulerAnswers;

namespace projecteulerAnswersTests
{
    [TestClass]
    public class Problem1Test
    {
        [TestMethod]
        public void GetMultiplesOf3Or5()
        {
            var expected = 233168;
            var actual = Problem1.GetMultiplesOf3Or5();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMultiplesOf3Or5Ext1()
        {
            var expected = 233168;
            var actual = Problem1.GetMultiplesOf3Or5Ext1();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GetSumOfArithmeticSequenceThrowException()
        {
            Problem1.GetSumOfArithmeticSequence(1, -1, 1);
        }

        [TestMethod]
        public void GetSumOfArithmeticSequence()
        {
            var expected = 84;
            var actual = Problem1.GetSumOfArithmeticSequence(3, 23 / 3, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
