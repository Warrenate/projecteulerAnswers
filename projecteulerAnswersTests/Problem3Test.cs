using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projecteulerAnswers;

namespace projecteulerAnswersTests
{
    [TestClass]
    public class Problem3Test
    {
        [TestMethod]
        public void GetLargestPrimeFactorOf()
        {
            var expected = 6857UL;
            var actual = Problem3.GetLargestPrimeFactorOf(600851475143);
            Assert.AreEqual(expected, actual);
        }
    }
}
