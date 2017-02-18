using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class Factorial : Interfaces.IFactorial
    {
        public int Iterative(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Please pick a whole number greate than zero");
            }
            else if (n >= 26)
            {
                throw new ArgumentException("Ahh! Too much! Choose a number 25 or less.");
            }
            else
            {
                int iterativeResult = 1;

                for (int i = 1; i <= n; i++)
                {
                    iterativeResult = iterativeResult * i;
                }
                return iterativeResult;
            }
        }

        public int Recursive(int n) 
        {
        //used msdn methodology...https://msdn.microsoft.com/en-us/library/z3dk2cc3(v=vs.100).aspx
            if (n < 0)
            {
                throw new ArgumentException("Cannot take factorial of negative number");
            }
            else if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n >= 26)
            {
                throw new ArgumentException("Ahh! Too much! Choose a number 25 or less.");
            }
            else
            {
                int recursiveResult = n * Recursive(n - 1);
                return recursiveResult;
            }
        }
    } 
}
