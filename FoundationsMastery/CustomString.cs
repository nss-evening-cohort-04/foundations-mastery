using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class CustomString : Interfaces.ICustomString
    {
        public IEnumerable<char> Contents { get; set; }

        public CustomString(char[] stringArray)
        {
            Contents = stringArray;
        }

        public int Length
        {
            get
            {
                return Contents.Count();
            }
        }

        public string Print()
        {
            return string.Concat(Contents); //use this for the Concat function, too.
        }

        public string Concat(IEnumerable<char> rhs)
        {
            //Need to convert char to string... first needed to push into an Array:
            string existingChars = new string(Contents.ToArray()).ToString();
            string newChars = new string(rhs.ToArray()).ToString();
            string concatinatedString = string.Concat(existingChars, newChars);
            return concatinatedString;
        }

        public void Clear()
        {
            Contents = null;
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            //this was my resource...https://msdn.microsoft.com/en-us/library/dd267698(v=vs.110).aspx

            //Here'e the content:
            /*
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };

            var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

            foreach (var item in numbersAndWords)
                Console.WriteLine(item);
            */
            // This code produces the following output:

            // 1 one
            // 2 two
            // 3 three

            //End Content

            //This was my first attempt, didn't work:
            /*string contentsString = new string(Contents.ToArray());
            string rhsString = new string(rhs.ToArray());
            string interleaveString = contentsString.Zip(rhsString, (string first, string second) => first + second);
             */

            //Second Attempt: returns numbers associated with the Zip method
            //var interleaveSequence = Contents.Zip(rhs, (first, second) => first + second);


            //Third Attempt:
            List<char> contentsList = Contents.ToList();
            List<char> rhsList = rhs.ToList();
            List<string> interleaveSequence = contentsList.Zip(rhsList, (char first, char second) => first.ToString() + second.ToString()).ToList();

            string combinedString = "";

            foreach(var item in interleaveSequence)
            {
                combinedString += item;
            }

            return combinedString;
        }
        




    }
}
