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
        private char[] mychars;

        public CustomString()
        {
        }

        public CustomString(char[] mychars)
        {
            this.mychars = mychars;
        }

        public IEnumerable<char> Contents
        {
            get
            {
                return mychars;
            }

            set
            {
                mychars = value.ToArray();
            }
        }

        public int Length
        {
            get
            {
                return mychars.Length;
            }
        }

        public void Clear()
        {
            mychars = new char[] { };
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
    }
}
