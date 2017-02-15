using System;
using System.Collections.Generic;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class CustomString : ICustomString
    {
        public CustomString()
        {

        }

        public CustomString(char[] chars)
        {
            Contents = chars;
        }

        public IEnumerable<char> Contents
        {
            get
            {
                return Contents;
            }

            set
            {
                Contents = value;
            }
        }

        public int Length
        {
            get
            {
                return Contents.ToString().Length;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
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