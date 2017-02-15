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
            this.Contents = userPassedArray;
        }

        public IEnumerable<char> Contents
        {
            get
            {
                return Contents;
            }

            set
            {
                this.Contents = value;
            }
        }

        public int Length
        {
            get
            {
                return this.Contents.Count();
            }
        }

        public void Clear()
        {
            this.Contents = new char[this.Contents.ToString().Length];
        }

        public string Concat(IEnumerable<char> rhs)
        {
            string contentsString = new string(Contents.ToArray()).ToString();
            return contentsString + string.Join("", rhs);
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            string userString = new string(rhs.ToArray());
            string oddChars = "";
            string evenChars ="";
            for(int i = 0; i < rhs.Count(); i++)
            {
                if(i%2 != 0)
                {
                    oddChars += userString.Substring(i,1);
                }
                else
                {
                    evenChars += userString.Substring(i, 1);
                }
            }
            return evenChars + oddChars;
        }

        public string Print()
        {
            return new string(Contents.ToArray());
        }
    }
}
