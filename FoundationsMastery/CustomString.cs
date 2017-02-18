using FoundationsMastery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
                return contents.Count();
            }
        }

        public void Clear()
        {
            contents = null;
        }

        public string Concat(IEnumerable<char> rhs)
        {
            var concatResults = contents.Concat(rhs);
            string charString = null;
            foreach (char x in concatResults)
            {
                charString += x;
            }
            return charString;
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            CustomString myString = new CustomString();
            char[] argArray = rhs.ToArray();
            char[] contentArray = contents.ToArray();
            char[] interleaveOutput = new char[argArray.Count() + contentArray.Count()];
            string interleaveOutputString = null;

            IEnumerable<string> numbersAndWords = contentArray.Zip(argArray, (first, second) => first + "" + second);

            foreach (string x in numbersAndWords)
            {
                interleaveOutputString += x;
            }

            return interleaveOutputString;
        }

        public string Print()
        {
            string charString = null;
            foreach (char x in contents)
            {
                charString += x;
            }
            Console.WriteLine("contents: " + charString);
            return charString;
        }
    }
}