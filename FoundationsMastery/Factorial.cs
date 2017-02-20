using System;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class Factorial : IFactorial
    {
        public int Iterative(int n)
        {
            int product = 1;
            //for (int j = 1; j <= n; j++)
            //    product *= j;
            if (n == 1)
            {
                return 1;
            }
            else if (n < 1)
            {
                throw new ArgumentException("entry needs to be 1 or greater");
            }
            while (n > 1)
            {
                product = product * n;
                n = n - 1;
            }
            return product;

        }

        public int Recursive(int n)
        {


            if (n == 0)
            {
                return 1;
            }
            else if (n < 1) 
            {
                throw new ArgumentOutOfRangeException("entry needs to be 1 or greater");
            }
            else 
            {
                return n * Recursive(n - 1);
            }

        }
    }
}
