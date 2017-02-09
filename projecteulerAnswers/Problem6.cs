using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteulerAnswers
{

    /// <summary>
    /// 6. Sum square difference https://projecteuler.net/problem=6
    /// </summary>
    public class Problem6
    {
        public static ulong GetSumOfEachNumberIn(ulong maxNum)
        {
            return maxNum * (maxNum + 1) / 2;
        }

        public static ulong GetSquareOfSumOfEachNumberIn(ulong maxNum)
        {
            ulong num = GetSumOfEachNumberIn(maxNum);
            return num * num;
        }

        public static ulong GetSumOfSquareOfEachNumberIn(ulong maxNum)
        {
            return maxNum * (maxNum + 1) * (2 * maxNum + 1) / 6;
        }
    }
}
