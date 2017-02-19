using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Classes
{
    public class CustomString : ICustomString
    {
        public CustomString(IEnumerable<char> mychars)
        {
            Contents = mychars.ToArray();
        }

        public IEnumerable<char> Contents { set; get; }

        public int Length
        {
            get
            {
                return Contents.Count();
            }
        }

        public void Clear()
        {
            Contents = new List<char>();
            //Contents = new char[] {  };
        }

        public string Concat(IEnumerable<char> rhs)
        {
            var myList = Contents.ToArray();
            var rhsList = rhs.ToArray();

            var newArray = myList.Concat(rhsList);
            return string.Concat(newArray);
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            var contents = Contents.ToArray();
            var rhsToArray = rhs.ToArray();
            var counter = 0;
            var newString = "";

            for (var i = 0; i < contents.Length; i++)
            {
                var newContentString = contents[i].ToString();
                var newRhsString = rhsToArray[i].ToString();
                newString += newContentString + newRhsString; 
                counter = counter + 1;
            }
            return newString;

            //throw new NotImplementedException();
        }

        public string Print()
        {
            return string.Concat(Contents);
        }
    }
}
