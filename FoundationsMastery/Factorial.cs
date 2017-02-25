using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Factorial : Interfaces.IFactorial
    {
        public Factorial()
        {

        }

        public int Iterative(int n) //method template was provided by instructor
        {
            //  Make an Enumerable up to n OR mutate a temporary variable
            int iterativeResult = 1;
            //  Iterate over your enumerable OR up/down to your temporary variable
            for (int i = 1; i <= n; i++)
            {
                iterativeResult *= i;
            }
            //  return some number

            return iterativeResult;
        }

        public int Recursive(int n) //method template was provided by instructor
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                // Recursion keeps going
                return Recursive(n);
            }
        }
    }

}

