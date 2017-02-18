using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Factorial : Interfaces.IFactorial
    {

        //0! = 1
        //1! = 1
        //2! = 2 * 1! = 2
        //3! = 3 * 2! = 6
        //... 
        //n! = n* (n - 1)!

        public int Iterative(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException();
            }
            int sum = 1;
            for(int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }

        public int Recursive(int n)
        {
            //return (n == 0) ? 0 = Recursive(n - 1) + n ;
            if(n <= 0)
            {
                throw new ArgumentException();
            }
            if (n == 1)
            {
                return 1;
            }
            return n * Recursive(n - 1);
        }
    }
}
