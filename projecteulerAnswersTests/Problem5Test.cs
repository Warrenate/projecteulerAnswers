using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projecteulerAnswers;

namespace projecteulerAnswersTests
{
    [TestClass]
    public class Problem5Test
    {
        [TestMethod]
        public void GetLCMOfEachNumberIn()
        {
            var expected = 232792560UL;
            var actual = Problem5.GetLCMOfEachNumberIn(20);
            Assert.AreEqual(expected, actual);
        }
    }
}
