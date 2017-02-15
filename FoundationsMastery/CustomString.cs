using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class CustomString : Interfaces.ICustomString
    {

        //private string myCustomString;
        private List<char> myCustomString = new List<char>() {'a','b','c'};
        
        //List<char> mychars2 = new List<char>() { 'a', 'b', 'c' };

        public IEnumerable<char> Contents
        {
            get
            {
                return myCustomString;//.AsEnumerable<char>();
            }

            set
            {
                myCustomString = value.ToList();
            }
        }

        public int Length
        {
            get
            {
                //lenghth of contents
                //int result = 0;
                //while (Contents.MoveNext())
                //{
                //    result++;
                //}
                //return result;
                throw new NotImplementedException();
            }
        }

        public void Clear()
        {   
            //clear Contents method
            //clears all enter strings?
            throw new NotImplementedException();
        }

        public string Concat(IEnumerable<char> rhs)
        {
            //combines with string in contents to the string in rhs
            //adds string A + string B = string C
            throw new NotImplementedException();
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            //"http://algorithmsandme.in/2014/05/if-string-is-interleaved-of-two-strings/"
            // string C = contents of string A and string B
            // if length passes check first char C with A, then 2nd then 3rd, repeat with B using loop until pass/fail

            //string a = 1,2,3
            //string b = a,b,c

            //result = 1a2b3c

            throw new NotImplementedException();
        }

        public void Output()
        {
            //prints result
            //returns string result
            Console.WriteLine(Contents);
        }

        public string Print()
        {
            //prints result
            //returns string result
            throw new NotImplementedException();
        }
    }
}
