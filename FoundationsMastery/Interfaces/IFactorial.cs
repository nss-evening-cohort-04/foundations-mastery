using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Interfaces
{
    interface IFactorial
    {
        //factorial is the product of an integer and all the integers below it; e.g., factorial four ( 4! ) is equal to 24.
        int Iterative(int n); // good when n >= 1 -- so *hint* is it should break if it is NOT 'good'
        int Recursive(int n); // good when n >= 1 -- so *hint* is it should break if it is NOT 'good'
        //recursive calls itself, iterative loops through idk whatever but each should return the same value -- implement same formula, just written differently
    }
}
