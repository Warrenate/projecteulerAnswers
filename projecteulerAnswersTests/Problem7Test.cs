using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projecteulerAnswers;

namespace projecteulerAnswersTests
{
    [TestClass]
    public class Problem7Test
    {
        [TestMethod]
        public void GetPrimeInIndexOf()
        {
            var expected = 104743UL;
            var actual = Problem7.GetPrimeInIndexOf(10001);
            Assert.AreEqual(expected, actual);
        }
    }
}
