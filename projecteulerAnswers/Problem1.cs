using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteulerAnswers
{
    /// <summary>
    /// 1. Multiples of 3 and 5 https://projecteuler.net/problem=1
    /// </summary>
    class Problem1
    {
        /// <summary>
        /// by myself
        /// </summary>
        /// <returns></returns>
        public static int GetMultiplesOf3Or5()
        {
            int result = 0;
            for (int i = 3; i < 1000; i += 3)
            {
                result += i;
            }
            for (int i = 5; i < 1000; i += 5)
            {
                result += i;
            }
            for (int i = 15; i < 1000; i += 15)
            {
                result -= i;
            }
            return result;
        }

        public static int GetMultiplesOf3Or5Ext1()
        {
            int maxIndex3 = 999 / 3;
            int maxIndex5 = 999 / 5;
            int maxIndex15 = 999 / 15;
            return GetSumOfArithmeticSequence(3, maxIndex3, 3) + GetSumOfArithmeticSequence(5, maxIndex5, 5) - GetSumOfArithmeticSequence(15, maxIndex15, 15);
        }

        public static int GetSumOfArithmeticSequence(int firstItem, int maxIndex, int step)
        {
            if (maxIndex < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("number can not less than 0!");
                throw new Exception();
            }
            // Sn = na1 + n * (n-1) * d / 2
            return maxIndex * firstItem + maxIndex * (maxIndex - 1) * step / 2;
        }
    }
}
