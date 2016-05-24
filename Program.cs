using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteulerAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Problem1.GetMultiplesOf3Or5());
            //Console.WriteLine(Problem1.GetMultiplesOf3Or5Ext1());

            //Console.WriteLine(Problem2.GetFabValueOf(50)); //too slow
            //Console.WriteLine(Problem2.GetEvenTermSumOfFibonacciIn(4000000));

            //Console.WriteLine(Problem3.GetLargestPrimeFactorOf(600851475143));

            ulong factor1;
            ulong factor2;
            Console.WriteLine("{0} = {1} * {2}", Problem4.GetLargestPalindromeProductOfTwoNumInDigitsOf(3, out factor1, out factor2), factor1, factor2);
            Console.WriteLine("{0} = {1} * {2}", Problem4.GetLargestPalindromeProductOfTwoNumInDigitsOfExt1(3, out factor1, out factor2), factor1, factor2);
            Console.WriteLine(Problem4.GetLargestPalindromeProductOfTwoNumInDigitsOf(3));
        }
    }
}
