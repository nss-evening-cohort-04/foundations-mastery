using System.Linq;
using System;
using System.Collections.Generic;
using FoundationsMastery.Interfaces;
using System.Collections;

namespace FoundationsMastery
{
    public class CustomString : ICustomString
    {
        public IEnumerable<char> Contents { get; set; }

        public CustomString(char[] mychars)
        {
            Contents = mychars;
        }

        public CustomString()
        {
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
            return myString.Clear();
        }

        public string Concat(IEnumerable<char> rhs)
        {
            return String.Concat(rhs);
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            throw new NotImplementedException();
        }

        public string Print()
        {
            return String.Concat(Contents);
        }
    }
}