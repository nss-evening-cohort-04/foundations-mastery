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
}

// public int Recursive(int value)
//    {
//        if (this makes the recursion stop)
 //       {
//            return some number
//        } else
//        {
//            recursion eeps going
//            return Recursive(mutate value and pass it inot itself)
//        }
//    }

//     public int Iterative(int n);
//      {
//          make a Enumberable up to n
//          Or something else
//          then iterate over your ennumberable
//          maybe stash temp results
//          return some number
//      }