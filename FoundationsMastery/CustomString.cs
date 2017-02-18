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
        public CustomString (char [] userPassedArray)
        {
            Contents = userPassedArray;
        }

        public IEnumerable<char> Contents { get; set; }

        public int Length
        {
            get
            {
                return Contents.Count();
            }
        }

        public virtual void Clear()
        {
           Contents = new char[] { };
        }

        public string Concat(IEnumerable<char> rhs)
        {
            string contentsString = new string(Contents.ToArray()).ToString();
            return contentsString + string.Join("", rhs);
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            int maxStringLength = 0;
            string string1 = new string(Contents.ToArray());
            string string2 = new string(rhs.ToArray());
            string newString = "";
            if (Contents.Count() > rhs.Count())
            {
                maxStringLength = Contents.Count();
            }
            else
            {
                maxStringLength = rhs.Count();
            }

            for (int i = 0; i <= maxStringLength; i++)
            {
                if (i < string1.Length)
                {
                    newString += string1[i];
                }
                if (i < string2.Length)
                {
                    newString += string2[i];
                }
            }
            return newString;
            
        }

        public virtual string Print()
        {
            return new string(Contents.ToArray());
        }
    }
}
