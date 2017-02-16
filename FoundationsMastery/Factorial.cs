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
            if (n < 2)
            {
                throw new ArgumentOutOfRangeException($"Value{n} is not greater than or equal to 1.");// way to put message in exception
            }
                int iterate = 1;
                for (int i = 0; i < n; i++)
                {
                    iterate *= i;
                }
                return iterate;
            }

        public int Recursive(int n)
        {
            if (n < 0)
            {
                throw new NotImplementedException($"Value{n} is not greater than or equal to 1.");// way to put message in exception;
            }

            if (n == 1)
            {
                return 1;
            }
            return n * Recursive(n - 1);
        }
    }
}
