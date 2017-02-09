using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteulerAnswers
{
    /// <summary>
    /// 3. Largest prime factor https://projecteuler.net/problem=3
    /// </summary>
    public class Problem3
    {
        public static bool IsPrimeNumber(ulong num)
        {
            if (num == 2)
                return true;
            ulong sqrtNum = (ulong)Math.Sqrt(num);
            for (ulong i = 3; i <= sqrtNum; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static ulong GetLargestPrimeFactorOf(ulong num)
        {
            ulong sqrtNum = (ulong)Math.Sqrt(num);
            sqrtNum = sqrtNum % 2 == 0 ? sqrtNum - 1 : sqrtNum;
            for (ulong i = sqrtNum; i > 2; i -= 2)
            {
                if (IsPrimeNumber(i) && num % i == 0)
                    return i;
            }
            return 0;
        }
    }
}
