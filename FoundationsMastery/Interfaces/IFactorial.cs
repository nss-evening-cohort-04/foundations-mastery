using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Interfaces
{
    interface IFactorial
    {
        int Iterative(int n); // good when n >= 1
        int Recursive(int n); // good when n >= 1
    }

    public class Factorial
    {
    }
}
