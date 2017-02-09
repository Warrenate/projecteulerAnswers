using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projecteulerAnswers;

namespace projecteulerAnswersTests
{
    [TestClass]
    public class Problem6Test
    {
        [TestMethod]
        public void TestDifferenceValue()
        {
            ulong num = 100;
            var squareOfSum = Problem6.GetSquareOfSumOfEachNumberIn(num);
            var sumOfSquare = Problem6.GetSumOfSquareOfEachNumberIn(num);
            var expected = 25164150UL;
            var actual = squareOfSum - sumOfSquare;
            Assert.AreEqual(expected, actual);
        }
    }
}
