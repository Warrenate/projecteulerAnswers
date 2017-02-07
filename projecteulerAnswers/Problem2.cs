using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteulerAnswers
{
    /// <summary>
    /// //2. Even Fibonacci numbers https://projecteuler.net/problem=2
    /// </summary>
    class Problem2
    {
        /// <summary>
        /// by myself. heavy computation.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static long GetFabValueOf(uint num)
        {
            if (num == 0)
                return 0;
            if (num == 1)
                return 1;
            return GetFabValueOf(--num) + GetFabValueOf(--num);
        }

        public static ulong GetFabValueOfIndex(ushort index)
        {
            if (index == 0)
                return 0;
            if (index == 1 || index == 2)
                return 1;
            ulong tempNum1 = 1;
            ulong tempNum2 = 1;
            ulong result = 0;
            while (index-- > 2)
            {
                if (tempNum1 + tempNum2 >= long.MaxValue >> 2)
                    return 0;
                result = tempNum1 + tempNum2;
                tempNum1 = tempNum2;
                tempNum2 = result;
            }
            return result;
        }

        public static bool IsAFiboNacci(ulong num)
        {
            ulong tempResult;
            for (ushort i = 0; ; i++)
            {
                tempResult = GetFabValueOfIndex(i);
                if (tempResult == num)
                    return true;
                if (tempResult > num)
                    return false;
            }
        }

        public static ulong GetEvenTermSumOfFibonacciIn(ulong maxTermValue)
        {
            ulong tempValue;
            ulong sum = 0;
            ulong tempNum1;
            ulong tempNum2 = 1;
            if (IsAFiboNacci(maxTermValue) && maxTermValue % 2 == 0)
                tempValue = maxTermValue + 1;
            else
                tempValue = maxTermValue;
            for (ulong i = 2; i < tempValue; i = tempNum1 + tempNum2)
            {
                tempNum1 = i + tempNum2;
                tempNum2 = i + tempNum1;
                sum += i;
            }
            return sum;
        }
    }
}
