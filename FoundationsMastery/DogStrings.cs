using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class DogStrings : ICustomString
    {
        public DogStrings(char[] inputArray)
        {
            this.Contents = inputArray;
        }

        public IEnumerable<char> Contents { get; set; }
            
        public int Length
        {
            get
            {
                return this.Contents.Count();
            }
        }

        public virtual void Clear()
        {
            this.Contents = null;
        }

        public string Concat(IEnumerable<char> rhs)
        {
            string dogString = new string(Contents.ToArray()).ToString();
            return dogString + string.Join("", rhs);
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            string result = "";
            //zip method to interleave
            var interleaveMe = Contents.Zip(rhs, (first, second) => first + "" + second);
            
            foreach (var item in interleaveMe)
            {
                result += item;
            }
                return result;
        }

        public string Print()
        {
            return String.Concat(Contents);
        }
    }
}
