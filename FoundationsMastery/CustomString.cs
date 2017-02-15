using FoundationsMastery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    class CustomString : ICustomString
    {
        public IEnumerable<char> Contents
        {
            // I have no idea what this is
        }

        public int Length
        {
            get
            {
                return Contents.Count();
            }
        }

        public void Clear()
        {
            return Contents.Clear();
        }

        public string Concat(IEnumerable<char> rhs)
        {

        }

        public string Interleave(IEnumerable<char> rhs)
        {

        }

        public string Print()
        {

        }
    }
}
