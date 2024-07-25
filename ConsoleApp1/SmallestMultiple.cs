using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
//    Problem Statement 
//     2520    is the smallest number that can be divided by each of the numbers from to  without any remainder.
//What is the smallest positive number that is evenly divisible(divisible with no remainder) by all of the numbers from  to?

//Input Format

//First line contains  that denotes the number of test cases.This is followed by  lines, each containing an integer, .

//Constraints

//Output Format

//Print the required answer for each test case.

//Sample Input 0

//2
//3
//10
//Sample Output 0

//6
//2520
    class SmallestMultiple
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt32(Console.ReadLine());
                long result = smallestDivisible(n);
                Console.WriteLine(result);
            }
        }

        public static long smallestDivisible(long N)
        {
            long divisor = 1;
            while (true)
            {
                for (long i = 1; i <= N; i++)
                {
                    if (!isDivisible(divisor, i))
                        break;
                    if (i == N)
                    {
                        return divisor;
                    }

                }
                divisor++;
            }
        }


        private static bool isDivisible(long num, long divisor)
        {
            if (num % divisor == 0)
                return true;
            return false;
        }
    }
}
