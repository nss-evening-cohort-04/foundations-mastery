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
        public IEnumerable<char> Contents { get; set; }// this will have value from the constructor

        public CustomString(IEnumerable<char> contents)
        {
            this.Contents = contents; // sets the value of the contents property from what is passed in the construtor
        }

        public CustomString()
        {
            this.Contents = new List<char>();//Always set empty constructor to a new list
        }


        public CustomString(char[] mychars)
        {
            Contents = mychars;
        }

        public int Length // give the length of the contents IEnumerable
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

        public string Concat(IEnumerable<char> rhs)//rhs == right hand side
        {
            string con = "";

            foreach (char c in this.Contents) // contents is a property
            {
                con += c;
            }
            foreach (char c in rhs)
            {
                con += c;
            }

            return con;
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            /*Did not work not sure why????
            var conListTest = Contents;
            var rhsListTest = rhs;
            var rhsAndCon = conListTest.Zip(rhsListTest, (first, second) => first + " " + second);

            foreach (var item in rhsAndCon)
            {
                return item;
            }
            */
            // ternary operator: (bool)? what the value if its true: what the value is if its false
            var length = (rhs.Count() > Contents.Count()) ? Contents.Count() : rhs.Count();
            var zipper = "";
            var conList = Contents.ToList();
            var rhsList = rhs.ToList();
            for (int i = 0; i < length; i++)
            {
                zipper += conList[i];
                zipper += rhsList[i];

            }
            return zipper;
        }

        public string Print()
        {
            string print = "";

            foreach (char c in this.Contents) // contents is a property of this class
            {
                print += c;
            }

            return print;
        }
    }
}
