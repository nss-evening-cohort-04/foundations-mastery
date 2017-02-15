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
                throw new System.ArgumentException("Parameter cannot be less than 1", "original");
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        public int Recursive(int n)
        {
            if (n <= 0)
                return 1;
            else
            {
                int y = n * Recursive(n - 1);
                return y;
            }
        }
    }
}
