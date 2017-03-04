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
        {   // the message is not necessary but it's nice if it were an app
            if (n < 1) { throw new ArgumentOutOfRangeException($"Value {n} is not greater than or equal to 1"); }
            int iterate = 1;
            for (var i = 1; i < n; i++)
            {
                iterate *= i;
            }
            return iterate;
        }

        public int Recursive(int n)
        { //recursive means that the function calls itself - it's very meta
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException($"Value {n} is not greater or equal to 1.");
            }
           
            if (n == 1)
            {
                return 1;
            }
               return n * Recursive(n - 1); // use a concrete example! similar to a loop, but backwards
            }
        }
    }

