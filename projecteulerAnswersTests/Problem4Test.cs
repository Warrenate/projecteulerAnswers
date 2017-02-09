using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projecteulerAnswers;

namespace projecteulerAnswersTests
{
    [TestClass]
    public class Problem4Test
    {
        [TestMethod]
        public void GetLargestPalindromeProductOfTwoNumInDigitsOf()
        {
            var expected = 906609UL;
            var actual = Problem4.GetLargestPalindromeProductOfTwoNumInDigitsOf(3);
            Assert.AreEqual(expected, actual);
        }
    }
}
