using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteulerAnswers
{
    /// <summary>
    /// 4. Largest palindrome product https://projecteuler.net/problem=4
    /// </summary>
    class Problem4
    {
        /// <summary>
        /// get the largest palindrome product of two same digit nums(inefficient).
        /// </summary>
        /// <param name="digits">digit count</param>
        /// <param name="factor1">factor 1</param>
        /// <param name="factor2">factor 2</param>
        /// <returns></returns>
        public static ulong GetLargestPalindromeProductOfTwoNumInDigitsOf(byte digits, out ulong factor1, out ulong factor2)
        {
            factor1 = factor2 = 0;
            if (digits == 1)
            {
                return 0;
            }
            ulong minNum = (ulong)Math.Pow(10, digits - 1);
            ulong maxNum = minNum * 10;
            ulong result = 0;
            ulong tempResult;
            for (ulong i = maxNum - 1; i > minNum; i--)
                for (ulong j = maxNum - 1; j > minNum; j--)
                {
                    tempResult = i * j;
                    if (IsPalindromeNumber(tempResult))
                    {
                        if (result < tempResult)
                        {
                            result = tempResult;
                            factor1 = j;
                            factor2 = i;
                        }
                    }
                }
            return result;
        }

        public static ulong GetLargestPalindromeProductOfTwoNumInDigitsOf(byte digits)
        {
            ulong factor1;
            ulong factor2;
            return GetLargestPalindromeProductOfTwoNumInDigitsOf(digits, out factor1, out factor2);
        }

        public static bool IsPalindromeNumber(ulong num)
        {
            string numToStr = num + string.Empty;
            char[] tempArr = numToStr.ToCharArray();
            Array.Reverse(tempArr);
            string newStr = new string(tempArr);
            return newStr == numToStr;
        }

        public static ulong GetLargestPalindromeProductOfTwoNumInDigitsOfExt1(byte digits, out ulong factor1, out ulong factor2)
        {
            factor1 = factor2 = 0;
            if (digits == 1)
            {
                return 0;
            }
            ulong minNum = (ulong)Math.Pow(10, digits - 1);
            ulong maxNum = minNum * 10;
            ulong result = 0;
            ulong tempResult;
            ulong step;
            ulong i, j;
            for (i = maxNum - 1; i > minNum; i--)
            {
                if (i % 11 == 0)
                {
                    j = maxNum - 1;
                    step = 1;
                }
                else
                {
                    j = GetLargestNum(digits, 11);
                    step = 11;
                }
                for (; j >= i; j -= step)
                {
                    tempResult = i * j;
                    if (result >= tempResult)
                        break;
                    if (IsPalindromeNumber(tempResult))
                    {
                        result = tempResult;
                        factor1 = j;
                        factor2 = i;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// get the largest number contain specified divisor and digit count
        /// </summary>
        /// <param name="digits">digit count</param>
        /// <param name="containFactor">contain factor</param>
        /// <returns></returns>
        public static ulong GetLargestNum(byte digits, ulong containFactor)
        {
            ulong maxNum = (ulong)Math.Pow(10, digits) - 1;
            while (maxNum > 0)
            {
                if (maxNum % containFactor == 0)
                    return maxNum;
                maxNum--;
            }
            return 0;
        }
    }
}
