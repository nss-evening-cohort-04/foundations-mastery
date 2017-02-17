using FoundationsMastery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class CustomString : ICustomString
    {
        public object mychars;

        public IEnumerable<char> Contents
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                char[] mychars = new char[] { 'a', 'b', 'c' };
            }
        }

        public int Length
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public char Char { get; private set; }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public string Concat(IEnumerable<char> rhs)
        {
            throw new NotImplementedException();
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            throw new NotImplementedException();
        }

        public string Print()
        {
            throw new NotImplementedException();
        }

        public CustomString(char mychars)
        {
            this.Char = mychars;
        }

        public CustomString(char[] mychars)
        {
            this.mychars = mychars;
        }

        public CustomString()
        {
        }
    }
}
