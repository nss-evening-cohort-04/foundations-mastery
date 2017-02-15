using FoundationsMastery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Factorial : IFactorial
    {
        public int Iterative(int n)
        {
            if (n >= 1)
            {
                int product = 1;
                for (int j = 1; j <= n; j++)
                {
                    product *= j;
                }
                return product;
            }
            else
            {
                System.ArgumentException test = new System.ArgumentException("this is s a test");
                throw test;
            }
        }

        public int Recursive(int n)
        {
            if (n >= 1)
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * Recursive(n - 1);
                }
            }
            else
            {
                System.ArgumentException test = new System.ArgumentException("this is s a test");
                throw test;
            }
        }
    }
}
