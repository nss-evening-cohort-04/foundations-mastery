using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    class Factorial
    {

        public int MyRecursiveFunc(int n) //method template provided by instructor
        {
            if (n == 0) 
            {
                return 1;
            } 
            else 
            {
                // Recursion keeps going
                return MyRecursiveFunc(n);
            }
        } 

        /*public int MyIterativeFunc(int n)//method template provided by instructor
        {
            //  Make an Enumerable up to n OR mutate a temporary variable
            //  Iterate over your enumerable OR up/down to your temporary variable
            //  Maybe stash the results?
            //  return some number
        }*/
    }

}

