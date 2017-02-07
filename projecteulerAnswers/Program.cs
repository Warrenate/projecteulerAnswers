#define problem7

using System;
using System.Diagnostics;

namespace projecteulerAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            TestP1();
            TestP2();
            TestP3();
            TestP4();
            TestP5();
            TestP6();
            TestP7();
        }

        [Conditional("problem1")]
        static void TestP1()
        {
            Console.WriteLine(Problem1.GetMultiplesOf3Or5());
            Console.WriteLine(Problem1.GetMultiplesOf3Or5Ext1());
        }

        [Conditional("problem2")]
        static void TestP2()
        {
            Console.WriteLine(Problem2.GetFabValueOf(10)); //too slow
            Console.WriteLine(Problem2.GetFabValueOfIndex(10));
            Console.WriteLine(Problem2.GetEvenTermSumOfFibonacciIn(4000000));
        }

        [Conditional("problem3")]
        static void TestP3()
        {
            Console.WriteLine(Problem3.GetLargestPrimeFactorOf(600851475143));

        }

        [Conditional("problem4")]
        static void TestP4()
        {
            ulong factor1;
            ulong factor2;
            Console.WriteLine("{0} = {1} * {2}", Problem4.GetLargestPalindromeProductOfTwoNumInDigitsOf(3, out factor1, out factor2), factor1, factor2);
            Console.WriteLine("{0} = {1} * {2}", Problem4.GetLargestPalindromeProductOfTwoNumInDigitsOfExt1(3, out factor1, out factor2), factor1, factor2);
            Console.WriteLine(Problem4.GetLargestPalindromeProductOfTwoNumInDigitsOf(3));
        }

        [Conditional("problem5")]
        static void TestP5()
        {
            Console.WriteLine(Problem5.GetLCMOfEachNumberIn(20));
        }

        [Conditional("problem6")]
        static void TestP6()
        {
            ulong num = 100;
            Console.WriteLine("square of sum - sum of square in {0} is {1}", num, Problem6.GetSquareOfSumOfEachNumberIn(num) - Problem6.GetSumOfSquareOfEachNumberIn(num));
        }

        [Conditional("problem7")]
        static void TestP7()
        {
            Console.WriteLine(Problem7.GetPrimeInIndexOf(10001));
        }
    }
}
