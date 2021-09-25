using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Recursion
    {
        public int factorial(int n)
        {
            if(n<=1)
            {
                //base case we don't want to multiply by 0 
                return 1;
            }
            else
            {
             // recursion
                return n * factorial(n - 1);
            }           
        }

        public int Summation(int n)
        {
            if (n <= 0)
            {
                //base case we don't want to multiply by 0 
                return 1;
            }
            else
            {
                //recursion
                return n + factorial(n - 1);
            }
        }
        public int Exponential(int e, int p)
        {
            //Base case
            if(p<=0)
            {
                return 1;
            }
            else
            {
                // recursive case
                // e to n -- here e is not changing but the n is changing
                return e * Exponential(e, p - 1);
            }
        }


    }
}
