using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteulerAnswers
{
    class UtilityAnswers
    {
        //1. Find the sum of all the multiples of 3 or 5 below 1000.
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
    }
}
