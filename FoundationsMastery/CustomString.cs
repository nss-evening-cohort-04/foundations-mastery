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

        //rhs == right hand side
        public string Concat(IEnumerable<char> rhs) //concat = adding 2 IEnumerables into one string
        {
            string concat = "";

            foreach (char a in this.Contents) //contents is a property on this class
            {
                concat += a;
            }

            foreach (char a in rhs) //rhs is the value being passed in
            {
                concat += a;
            }
            return concat;
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
