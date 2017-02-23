using FoundationsMastery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class CustomString : Interfaces.ICustomString
    {
        

        public CustomString(char[] mychars)
        {
            Contents = mychars;
        }

        public CustomString()
        {}

        public IEnumerable<char> Contents
        {
            get; set;
        }

        public int Length
        {
            get;
        }

        public void Clear()
        {
            Contents = null;
        }

        public string Concat(IEnumerable<char> rhs)
        {
            return Contents.Concat(rhs).ToString();
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            {
                string valuePassed = String.Concat(rhs);
                string contents = String.Concat(Contents);
                string newString = "";
                for (int i = 0; i < Contents.Count(); i++)
                {
                    newString += contents[i];
                    newString += valuePassed[i];
                }
                return newString;
            }
        }

        public string Print()
        {
            return String.Concat(Contents);
        }
    }
}
