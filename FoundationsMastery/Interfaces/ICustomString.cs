using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Interfaces
{
    interface ICustomString
    {
        IEnumerable<char> Contents { set; get; }
        int Length { get; }
        void Print();
        string Concat(IEnumerable<char> rhs);
        void Clear();
        string Interleave(IEnumerable<char> first);
    }
}
