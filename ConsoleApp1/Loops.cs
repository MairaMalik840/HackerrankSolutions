using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{//Problem Statement
 //Objective
 //In this challenge, we will use loops to do some math. Check out the Tutorial tab to learn more.

    //Task
    //Given an integer, , print its first  multiples. Each multiple  (where ) should be printed on a new line in the form: n x i = result.

    //Example

    //The printout should look like this:

    //3 x 1 = 3
    //3 x 2 = 6
    //3 x 3 = 9
    //3 x 4 = 12
    //3 x 5 = 15
    //3 x 6 = 18
    //3 x 7 = 21
    //3 x 8 = 24
    //3 x 9 = 27
    //3 x 10 = 30
    //Input Format

    //A single integer, .

    //Constraints

    //Output Format

    //Print  lines of output; each line(where ) contains the  of  in the form:
    //n x i = result.
    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
                i++;
            }
        }
    }

}
