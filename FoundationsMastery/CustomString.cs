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
                throw new NotImplementedException();
            }
        }
        public void Clear()
        {
            Contents = new List<char>();
            Contents.ToList().Clear();
        }

        public string Concat(IEnumerable<char> rhs)
        {
            string concat = "";
            concat += Print();

                return concat;
;        }

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
