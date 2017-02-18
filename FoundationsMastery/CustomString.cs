using FoundationsMastery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class CustomString : ICustomString
    {
        public CustomString()
        {

        }

        public CustomString(char[] mychars)
        {
            Contents = mychars;
        }

        public IEnumerable<char> Contents { get; set; }

        public int Length
        {
            get
            {
                return Contents.Count();
            }
        }

        public void Clear()
        {
            Contents = new char[] { }; ;
        }

        public string Concat(IEnumerable<char> rhs)
        {
            return Contents.Concat(rhs).ToString();
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            var maxLength = Math.Max(Length, rhs.Count());

            List<char> result = new List<char>();

            for (var i = 0; i < maxLength; i++)
            {
                if(i < Length)
                {
                    result.Add(Contents.ElementAt(i));
                }
                if(i < rhs.Count())
                {
                    result.Add(rhs.ElementAt(i));
                }
            }

            return String.Join("",result);
        }

        public string Print()
        {
            return string.Join("", Contents.ToArray());
        }
    }
}
