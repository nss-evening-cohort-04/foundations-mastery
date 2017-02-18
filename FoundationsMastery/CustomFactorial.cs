using System;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class CustomFactorial : IFactorial
    {
        public CustomFactorial()
        {
        }

        public int Iterative(int n) // good when n >= 1
        {
            if (n < 1)
            {
                throw new ArgumentException("Iterative argument is less than 1.");
            }
            int iterativeOutput = 1;
            for (int i=n; i >= 1; i--)
            {
                iterativeOutput = iterativeOutput * i;
            }
            return iterativeOutput;
        }

        public int Recursive(int n) // good when n >= 1
        {
            if (n < 1)
            {
                throw new ArgumentException("Recursive argument is less than 1.");
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Recursive(n - 1);
            }
        }
    }
}