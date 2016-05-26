using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteulerAnswers
{
    /// <summary>
    /// 5. Smallest multiple https://projecteuler.net/problem=5
    /// </summary>
    class Problem5
    {
        /// <summary>
        /// get the greatest common divisor of two number
        /// </summary>
        /// <param name="num1">number one</param>
        /// <param name="num2">number two</param>
        /// <returns></returns>
        public static ulong GetGCD(ulong num1, ulong num2)
        {
            ulong lowerNum;
            ulong greaterNum;
            ulong lowerNumSqrt;
            lowerNum = num1 > num2 ? num2 : num1;
            greaterNum = lowerNum == num1 ? num2 : num1;
            lowerNumSqrt = (ulong)Math.Sqrt(lowerNum);
            for (ulong i = lowerNum; i >= lowerNumSqrt; i--)
            {
                if (lowerNum % i == 0 && greaterNum % i == 0)
                    return i;
            }
            return 1;
        }

        /// <summary>
        /// get the lowest common multiple of two number
        /// </summary>
        /// <param name="num1">number one</param>
        /// <param name="num2">number two</param>
        /// <returns></returns>
        public static ulong GetLCM(ulong num1, ulong num2)
        {
            return num1 * num2 / GetGCD(num1, num2);
        }

        /// <summary>
        /// get the lowest common multiple from 1 to the specified max number
        /// </summary>
        /// <param name="maxNum">max number</param>
        /// <returns></returns>
        public static ulong GetLCMOfEachNumberIn(byte maxNum)
        {
            ulong result = 1;
            for (byte i = 2; i <= maxNum; i++)
                result = GetLCM(result, i);
            return result;
        }
    }
}
