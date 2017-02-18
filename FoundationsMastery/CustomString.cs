using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class CustomString : Interfaces.ICustomString
    {
        private IEnumerable<char> _Contents;

        public CustomString(IEnumerable<char> Contents)
        {
            _Contents = Contents;
        }

        //private string myCustomString;
        //private List<char> listOfChars = new List<char>() {'a','b','c'};

        //List<char> mychars2 = new List<char>() { 'a', 'b', 'c' };

        public IEnumerable<char> Contents
        {
            get
            {
                //return listOfChars; //AsEnumerable<char>();
                return _Contents;
            }

            set
            {
                //Contents = new char[] { 'a', 'b', 'c' };
                _Contents = value;
                //listOfChars = value.ToList();
            }
        }



        //attempt to overload to accept testing pass through
        //public IEnumerable<char> Contents(char[] value)
        //{
        //    get
        //    {
        //        //return listOfChars;//.AsEnumerable<char>();
        //        return Contents;
        //    }

        //    set
        //    {
        //        Contents = value;
        //        //listOfChars = value.ToList();
        //    }
        //}

        public int Length
        {
            get
            {
                //.length or .Length.ToString
                //string str = null;
                //str = "This is a Test";
                //MessageBox.Show(str.Length.ToString());

                //lenghth of contents
                //int result = 0;
                //while (Contents.MoveNext())
                //{
                //    result++;
                //}
                //return result;
                //throw new NotImplementedException();

                return 5;

                //int counter = 0;
                //foreach (var e in Contents)
                //{
                //    counter++;
                //}
                //return e;

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

            //string str1 = null;
            //string str2 = null;

            throw new NotImplementedException();

            //str1 = "Concat() ";
            //str2 = "Test";
            //MessageBox.Show(string.Concat(str1, str2));
            //CustomString(mychars);
            //string SomeString = CustomString.Concat(new char[] { 'a', 'b', 'c' });
            //return  SomeString + rhs;
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
