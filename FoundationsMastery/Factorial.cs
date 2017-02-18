using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class Factorial : IFactorial
    {
        public Factorial ()
        {

        }

        public int Iterative(int n)
        {
            if (n < 1) throw new InvalidOperationException();
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }

        public int Recursive(int n)
        {
            if (n < 1) throw new InvalidOperationException();
            int x;
            x = n * Iterative(n - 1);
            return x;
        }
    }
}
