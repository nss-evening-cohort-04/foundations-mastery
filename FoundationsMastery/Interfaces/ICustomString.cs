using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Interfaces
{
    interface ICustomString
    {
        IEnumerable<char> Contents { set; get; } // contents embedded in class that's an ienum for chars, contents will have a property
        int Length { get; }
        string Print();
        string Concat(IEnumerable<char> rhs); // add the strings together "aaa + bbb = aaabbb"
        void Clear(); //make it empty, clear all data, doesn't need to have filler spaces
        string Interleave(IEnumerable<char> rhs); // add strings together "aaa + bbb = ababab"
    }
}
