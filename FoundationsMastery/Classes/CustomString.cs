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
            Contents = mychars;
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
        }

        public string Concat(IEnumerable<char> rhs)
        {
            var myList = Contents.ToArray();
            var rhsList = rhs.ToArray();

            var newArray = myList.Concat(rhsList).ToArray();
            return newArray.ToString();
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            throw new NotImplementedException();
        }

        public string Print()
        {
            return Contents.ToString();
        }
    }
}
