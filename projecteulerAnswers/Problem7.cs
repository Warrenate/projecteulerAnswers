using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteulerAnswers
{
    /// <summary>
    /// 7. 10001st prime https://projecteuler.net/problem=7
    /// </summary>
    class Problem7
    {
        public static ulong GetPrimeInIndexOf(ushort index)
        {
            if (index == 1)
                return 2;
            for (ulong i = 3; ; i += 2)
            {
                if (Problem3.IsPrimeNumber(i))
                    index--;
                if (index == 1)
                    return i;
            }
        }
    }
}
