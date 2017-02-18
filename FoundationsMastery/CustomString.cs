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
            mychars = new char[0];
        }

        public string Concat(IEnumerable<char> rhs)
        {
            var concatString = "";

            foreach (var instance in Contents )
            {
                concatString += instance;
            }
            foreach (var instance in rhs)
            {
                concatString += instance;
            }
            return concatString;
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            var lhs = Contents.ToList();
            var nextRhs = rhs.ToList();
            var finalDestination = new char[lhs.Count() + nextRhs.Count()];

            for (int i = 0; i < Length; i++)
            {
                finalDestination[i * 2] = lhs[i];
            }

            for (int i = 0; i < nextRhs.Count(); i++)
            {
                finalDestination[(i * 2) + 1] = nextRhs[i];
            }

            return String.Join("", finalDestination);

        }

        public string Print()
        {
            return String.Join("", Contents);
        }
    }
}
