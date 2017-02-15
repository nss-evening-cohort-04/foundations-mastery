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
        public CustomString() //dont leave this constructor totally empty
        {
            this.Contents = new List<char>();
        }

        public CustomString(IEnumerable<char> contents)
        {
            this.Contents = contents; // sets the value of the contents property from what is passed in the constructor
        }

        public IEnumerable<char> Contents { get; set; } // this will have value from the constructor
        //IEnumerables are Interfaces -- they can't be instantiated 


        public int Length //give the length of the contents IEnumerable
        {
            get
            {
                return this.Contents.Count(); // bc stored as IEnumerable, you have to use Count method vs. Length
            }
        } //give the length of the contents IEnumerable

        public void Clear() //clear means this.Contents should be empty
        {
            //Contents = new List<char>(); 
            Contents.ToList().Clear();
        }

        public string Print() //print to console, return string
        {
            string print = "";

            foreach (char a in this.Contents)
            {
                print += a;
            }

            //Console.WriteLine(print);

            return print;
        }

        //rhs == right hand side
        public string Concat(IEnumerable<char> rhs) //concat = adding 2 IEnumerables into one string
        {
            string concat = "";

            concat += Print(); // leveraging code from Print to use here

            foreach (char a in rhs) //rhs is the value being passed in
            {
                concat += a;
            }
            return concat;
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            //ternary operator-- (bool) ? what the value is if it's true : what the value is if it's false 
           var length = (rhs.Count() > Contents.Count()) ? Contents.Count() : rhs.Count();
           var contentList = Contents.ToList();
           var rhsList = rhs.ToList();
           var zipper = "";

           for (var i = 0; i < length; i++)
            {
                zipper += contentList[i];
                zipper += rhsList[i];
            }

            return zipper;
        }

    }
}
