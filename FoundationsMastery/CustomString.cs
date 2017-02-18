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
            this.Contents = Contents;
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

                return Contents.Count();

            }
        }

        public void Clear()
        {
            //clear Contents
            Contents = new List<char>();
        }

        public string Concat(IEnumerable<char> rhs)
        {
            //combines with string in contents to the string in rhs
            //adds string A + string B = string C

            List<char> listContents = Contents.ToList(); //abc
            List<char> listrhs = rhs.ToList(); //xyz

            List<char> concatList = listContents.Concat(listrhs).ToList();

            string result = string.Concat(concatList);
            //string result = concatList.ToString();

            return result;


            //string str1 = null;
            //string str2 = null;

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

            //turn into list
            List<char> listContents = Contents.ToList();
            List<char> listrhs = rhs.ToList();

            //loop with ifs?

            //var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);
            //string.format("{0}{1}", first, second) or $"{first}{second}"
            List<string> zipString = listContents.Zip(listrhs,(char first, char second) => first.ToString() +  second.ToString()).ToList();

            string result = "";
            // foreach (var item in numbersAndWords)
            foreach (var item in zipString)
            {
                 result += item;
            }

            //string result = 

            return result;

                //string a = a,b,c
                //string b = x,y,z

                //result = axbycz

                throw new NotImplementedException();
        }

        //public void Output()
        //{
        //    //prints result
        //    //returns string result
        //    Console.WriteLine(Contents);
        //}

        public string Print()
        {
            string result = string.Concat(Contents);
            //string result = concatList.ToString();

            return result;
        }
    }
}
