using FoundationsMastery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.models
{
    
    public class CustomString : ICustomString
    {
        public CustomString()
        {

        }

        public CustomString(IEnumerable<char> args)
        {
            Contents = args;
        }

        public IEnumerable<char> Contents { get; set; }

        public int Length
        {
            get
            {
                return Contents.Count();
            }
        }

        public virtual void Clear()
        {
            Contents = null;
        }

        public string Concat(IEnumerable<char> rhs)
        {
            string concatString = "";

            foreach(char c in rhs)
            {
                concatString += c;
            }

            return concatString;
        }


        //zipper effect
        //uses content and IEnumberable 
        public string Interleave(IEnumerable<char> rhs)
        {
            string returnString = "";

            //use Enumerable.Zip function
            var zippedCollection = Contents.Zip(rhs, (first, second) => first.ToString()+second.ToString());

            foreach (var item in zippedCollection)
            {
                returnString += item;
            }
            
            return returnString;
        }

        public virtual void Print()
        {
            Console.WriteLine(Contents.ToString());
        }

    }
}
