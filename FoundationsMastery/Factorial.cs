using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class Factorial : IFactorial
    {
        public virtual int Iterative(int n)
        {
            int[] intArr= new int[n];
            intArr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                intArr[i] = (i + 1) * intArr[i - 1]; 
            }
            return intArr[n-1];
        }

        public virtual int Recursive(int n)
        {
            if (n < 1)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Recursive(n - 1);
            }
        }
    }
}
