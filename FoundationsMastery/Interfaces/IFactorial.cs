using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Interfaces
{
    public interface IFactorial
    {
        int Iterative(int n); // good when n >= 1 itterates over list
        int Recursive(int n); // good when n >= 1 calls itself
    }
}
