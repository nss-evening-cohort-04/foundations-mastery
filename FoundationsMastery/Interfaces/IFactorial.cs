using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Interfaces
{
    interface IFactorial
    {
        //research what Factorial is...msdn has javascript formula
        //goes over numbers...look up what iterative and recursive mean
        int Iterative(int n); // good when n >= 1

        //calls itself
        int Recursive(int n); 

    }
}
