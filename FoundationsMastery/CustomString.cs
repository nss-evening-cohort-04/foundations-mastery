using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FoundationsMastery.CustomString
{
    public class CustomString : Interfaces.ICustomString
    {
        public IEnumerable<char> Contents{ get; set; }

        // sets Contents to the IEnumerableArray of chars
        public CustomString(char[] enumArray)
        {
            Contents = enumArray;   
        }

        // returns the number of items in the array
        public int Length
        {
            get
            {
                return Contents.Count();
            }
        }

        // sets Contents to null
        public void Clear()
        {
            Contents = null;
        }

        public string Concat(IEnumerable<char> rhs)
        {
            return String.Concat(rhs);
        }

        // Interleave with "Contents" and a string you pass to this method
        public string Interleave(IEnumerable<char> rhs)
        {
            // Convert IEnum to string
            // I could have passed these values to Concat(), 
            // but this is more self contained.
            string valuePassed = String.Concat(rhs);
            string contents = String.Concat(Contents);
            string result = "";
            for (int i = 0; i < Contents.Count(); i++)
            {
                result += $"{contents[i]}{valuePassed[i]}";
            }
            return result;
        }

        public string Print()
        {
            return String.Concat(Contents);
        }
    }
}
