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
        private char[] contents;

        public IEnumerable<char> Contents
        {
            get
            {
                return contents;
            }

            set
            {
                 contents = value.ToArray();
            }
        }

        public int Length
        {
            get
            {
                return contents.Length;
            }
        }

        public void Clear()
        {
             contents = new char[0];
        }

        public string Concat(IEnumerable<char> rhs)
        {
            
            string s = new string(Contents.ToArray()) + new string(rhs.ToArray());
            return s;
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            var a = Contents.ToArray();
            var b = rhs.ToArray();
            string mystring = "";

            for (int i = 0; i < a.Length; i++)
            {
               mystring += a[i] + b[i];
            }

            return mystring;
        }

        public string Print()
        {
            throw new NotImplementedException();
        }

        public CustomString(char[] mychars)
        {
            this.contents = mychars;
        }

        public CustomString()
        {
        }
    }
}
