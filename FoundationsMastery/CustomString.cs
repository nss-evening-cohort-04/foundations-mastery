using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class CustomString : Interfaces.ICustomString
    {
        public IEnumerable<char> Contents { get; set; }

        public int Length
        {
            get
            {
                return Contents.Count();
            }
        } // give length of the IEnumberable Contents

        public CustomString()
        {
            this.Contents = new List<char>();
        }

        public CustomString(IEnumerable<char> newContents)
        {
            this.Contents = newContents;
        }

        public void Clear()
        {
            Contents = new List<char>(); //IEnumberables are Interfaces - they can't be instantiated - needs to be a List
            Contents.ToList().Clear();
        }

        // rhs == right hand side; a new IEnumerable that is being passed in (Contents can be accessed already)
        public string Concat(IEnumerable<char> rhs) //concat = adding two Ienuerables into one string
        {
            string concat = "";
            foreach  (char a in Contents) //contents is a property on this class
            {
                concat += a;
            }
            foreach (char a in rhs)
            {
                concat += a;
            }
            return concat;
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            // ternary operator: (bool) ? return value if true : return value if false
            var length = (rhs.Count() > Contents.Count()) ? Contents.Count() : rhs.Count();
            var conList = Contents.ToList();
            var rhsList = rhs.ToList();
            var zipper = "";

            for (var i = 0; i < length; i++)
            {
                zipper += conList[i];
                zipper += rhsList[i];
            }

            return zipper;
        }

        public string Print() //print to console, return string
        {
            string print = "";
            foreach (char a in Contents)
            {
                print += a;
            }

            Console.WriteLine(print);

            return print;
        }
    }
}
