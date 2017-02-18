using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Interfaces
{
     public interface ICustomString
    {
        IEnumerable<char> Contents { set; get; }// Contents holds the data 
        int Length { get; } // integer to get length of item
        string Print();
        string Concat(IEnumerable<char> rhs);//Concat Contents and rhs 
        void Clear();// clear contents data
        string Interleave(IEnumerable<char> rhs);// interleave will mix collection rhs
    }
}
