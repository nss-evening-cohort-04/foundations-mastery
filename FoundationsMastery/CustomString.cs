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
        public char[] mychars;
        IEnumerable<char> mycontents { get; set; }

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
                //foreach (char x in mychars)
                //{
                //    Contents += x.ToList();
                //};
                //return Contents;
                return mycontents;

            }

            set
            {
                Contents = mycontents.ToList();
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
            // MSDN & StackOverflow say you can't Remove items from IEnumerable -- 
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
