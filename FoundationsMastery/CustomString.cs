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

        public IEnumerable<char> Contents
        {
            get
            {
                return _Contents;
            }

            set
            {
                 _Contents = value;
            }
        }


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
            //combines with string in contents with the string in rhs
            //adds string A + string B = string C

            List<char> listContents = Contents.ToList(); //abc
            List<char> listrhs = rhs.ToList(); //xyz

            List<char> concatList = listContents.Concat(listrhs).ToList();

            string result = string.Concat(concatList);
            //string result = concatList.ToString();

            return result;
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            //string a = a,b,c
            //string b = x,y,z
            //result = axbycz

            //turn into two list
            List<char> listContents = Contents.ToList();
            List<char> listrhs = rhs.ToList();
            //string.format("{0}{1}", first, second) or $"{first}{second}"
            List<string> zipString = listContents.Zip(listrhs,(char first, char second) => first.ToString() +  second.ToString()).ToList();

            string result = "";

            foreach (var item in zipString)
            {
                 result += item;
            }

            return result;

        }


        public string Print()
        {
            string result = string.Concat(Contents);

            return result;
        }
    }
}
