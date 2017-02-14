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
        public char[] mychars;
        public List<char> mycontents
        {
            set
            {
                mycontents = Contents.ToList(); // are you kidding me
            }
            
        }

        public CustomString()
        {
        }

        public CustomString(char[] mychars)
        {
            this.mychars = mychars;
        }

        public IEnumerable<char> Contents
        {
            get
            {
                //foreach (char x in mychars)
                //{
                //    Contents += x.ToList();
                //};
                //return Contents;
                return Contents;

            }

            set
            {
                //Contents = mycontents.ToList(); //doesn't actually make Contents a list
            }
        }

       


        public int Length
        {
            get
            {

                return mychars.Length;
            }
        }

        public void Clear()
        {
            // MSDN & StackOverflow say you can't Remove items from IEnumerable -- must convert Contents to list
            //Contents.Clear();
        }

        public string Concat(IEnumerable<char> rhs)
        {
            throw new NotImplementedException();
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            throw new NotImplementedException();
        }

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}
