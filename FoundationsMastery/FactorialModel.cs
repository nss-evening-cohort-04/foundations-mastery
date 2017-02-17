using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class FactorialModel : IFactorial
    { 
        public FactorialModel()
        {

        }

        public virtual int Iterative(int n)
        {
            if(n < 1)
            {
                throw new InvalidOperationException();
            }

            var x = 1;

            for(var i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }

        public int Recursive(int n)
        {
            if (n < 1)
            {
                throw new InvalidOperationException();
            }

            int x;

            x = n * Iterative(n - 1);

            return x;
        }
    }
}
