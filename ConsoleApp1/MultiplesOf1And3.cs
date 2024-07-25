using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    //Problem Statement
    //    If we list all the natural numbers below  that are multiples of  or , we get  and.The sum of these multiples is .

    //Find the sum of all the multiples of  or below.

    //Input Format

    //First line contains  that denotes the number of test cases.This is followed by  lines, each containing an integer, .

    //Constraints

    //Output Format

    //For each test case, print an integer that denotes the sum of all the multiples of  or below .

    //Sample Input 0

    //2
    //10
    //100
    //Sample Output 0

    //23
    //2318
    class Multiples
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            long[] arr = new long[t];
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(SumOfMultiplesOf3Or5Below(n));
            }
        }

        public static long getSumOfMultiples(long N)
        {
            long sum = 0;
            for (long i = 0; i < N; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        public static long SumOfMultiplesOf3Or5Below(int N)
        {
            return SumDivisibleBy(3, N - 1) + SumDivisibleBy(5, N - 1) - SumDivisibleBy(15, N - 1);
        }

        private static long SumDivisibleBy(int divisor, int N)
        {
            long p = N / divisor;
            return divisor * p * (p + 1) / 2;
        }
    }
}
