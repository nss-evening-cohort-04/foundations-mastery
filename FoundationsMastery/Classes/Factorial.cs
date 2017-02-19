using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Classes
{
    public class Factorial : IFactorial
    {
        public int Iterative(int n)
        {
            int count = 1;
            if (n == 1)
            {
                return 1;
            }
            else if (n < 1)
            {
                throw new ArgumentException(n + " needs to be greater than 1");
            }
            while (n > 1)
            {
                count = count * n;
                n = n - 1;
            }
            return count;
        }

        public int Recursive(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n < 1)
            {
                throw new ArgumentException(n + " needs to be greater than 1");
            }
            return n * Recursive(n - 1);
        }

        public virtual void FactorialClass()
        {
            Console.WriteLine("This is in the Factorial Class");
            return;
        }
    }
}
