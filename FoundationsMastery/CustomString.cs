using System;
using System.Collections.Generic;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class CustomString : ICustomString
    {
        private IEnumerable<char> contents { get; set; }

        public CustomString()
        {

        }

        public CustomString(char[] chars)
        {
            contents = chars;
        }

        public IEnumerable<char> Contents
        {
            get
            {
                return contents;
            }

            set
            {
                contents = value;
            }
        }

        public int Length
        {
            get
            {
                string charString = null;
                foreach(char x in contents)
                {
                    charString += x;
                }
                return charString.Length;
            }
        }

        public void Clear()
        {
            contents = null;
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