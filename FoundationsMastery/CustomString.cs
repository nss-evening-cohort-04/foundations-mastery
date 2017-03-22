using System.Linq;
using System;
using System.Collections.Generic;
using FoundationsMastery.Interfaces;
using System.Collections;

namespace FoundationsMastery
{
    public class CustomString : ICustomString
    {
        public IEnumerable<char> Contents { get; set; }

        public CustomString(char[] mychars)
        {
            Contents = mychars;
        }

        public CustomString()
        {
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
            Contents = new char[0];
        }

        public string Concat(IEnumerable<char> rhs)
        {
            return String.Concat(rhs);
        }

        public string Print()
        {
            throw new NotImplementedException();
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            throw new NotImplementedException();
        }

        //public string Interleave(IEnumerable<char> rhs)
        //{

    }

    //public string Print()
    //{
   
    var myString = new CustomString(new char[] { 'a', 'b', 'c' };
                    myString.Concat("123");       // => returns "abc123"

          return String.Concat(Contents);
        }
//}
