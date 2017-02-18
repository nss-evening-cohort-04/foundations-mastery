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
            if (n > 0)
            {
                int result = 1;

                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
            else
                throw new ArgumentException("Must be greater than 0");
        }

        public int Recursive(int n)
        {
            if (n > 1)
            {
                return n * Recursive(n - 1);
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException();
            }
        }
    }
}
