using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class CustomString : Interfaces.ICustomString
    {
        public IEnumerable<char> Contents
        {
            get
            {
                //new string
                throw new NotImplementedException();
            }

            set
            {
                //to assigned string A or B
                throw new NotImplementedException();
            }
        }

        public int Length
        {
            get
            {
                //gets length of the string
                throw new NotImplementedException();
            }
        }

        public void Clear()
        {   
            //clear Contents method
            //clears all enter strings?
            //clears one string to allow a new to be entered?
            throw new NotImplementedException();
        }

        public string Concat(IEnumerable<char> rhs)
        {
            //adds string A + string B = string C
            throw new NotImplementedException();
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            //"http://algorithmsandme.in/2014/05/if-string-is-interleaved-of-two-strings/"
            // string C = contents of string A and string B
            // test Length of C to match Length of A + B
            // if length passes check first char C with A, then 2nd then 3rd, repeat with B using loop until pass/fail

            throw new NotImplementedException();
        }

        public string Print()
        {
            //prints result
            //returns string result
            throw new NotImplementedException();
        }
    }
}
