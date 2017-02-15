using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Factorial
{
    public class Factorial : Interfaces.IFactorial
    {
        public int Iterative(int n)
        {
            if (n <= 0)
                throw new System.ArgumentException("Y u no put real number??? Must be 1+");
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        public int Recursive(int n)
        {
            if (n < 1)
                throw new System.ArgumentOutOfRangeException();
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int y = n * Recursive(n - 1);
                return y;
            }
        }
    }
}
