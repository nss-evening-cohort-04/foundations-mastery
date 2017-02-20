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
        private int product;

        public int Iterative(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int product = 1;
            for (int j = 1; j <= n; j++)
            {
                product *= j;
            }
            return product;

        }

        public int Recursive(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            else if (n == 1)

            {

                return 1;

            }

            return n * Recursive(n - 1);

        }
    }
}
