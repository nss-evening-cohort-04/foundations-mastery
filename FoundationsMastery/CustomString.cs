using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class CustomString : ICustomString
    {
        protected IEnumerable<char> _customString;

        public CustomString(char[] arg)
        {
            Contents = arg as IEnumerable<char>;
        }

        public virtual IEnumerable<char> Contents
        {
            get
            {
                return _customString;
            }

            set
            {
                _customString = value;
            }
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
            Contents = null;
        }

        public virtual string Concat(IEnumerable<char> rhs)
        {
            return string.Concat(Contents.Concat(rhs).TakeWhile(char.IsLetter));
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            int len1 = this.Length;
            int len2 = rhs.Count();
            int n = (len1 - len2 > 0) ? len1 : len2;
            char[] buffer = new char[len1 + len2];
            int bufferIndex = 0;
            char[] s1 = Contents.ToArray();
            char[] s2 = rhs.ToArray();

            for (int sourceIndex = 0; sourceIndex < n; sourceIndex++)
            {
                if (sourceIndex < len1)
                    buffer[bufferIndex++] = s1[sourceIndex];

                if (sourceIndex < len2)
                    buffer[bufferIndex++] = s2[sourceIndex];
            }
            return new string(buffer, 0, bufferIndex);
        }

        public string Print()
        {
            return string.Concat(Contents);
        }
    }
}
