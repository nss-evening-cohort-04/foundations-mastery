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

        public CustomString(IEnumerable<char> contents)
        {
            this.Contents = contents;
        }

        public IEnumerable<char> Contents { get; set; } 
       
        public int Length {
            get
            {
                return this.Contents.Count(); 
            }
        } 

        public void Clear() 
        {
            Contents = new List<char>(); 
            Contents.ToList().Clear(); 
        }   

        public string Concat(IEnumerable<char> rhs) 
        {
            string concat = "";
            foreach (char a in this.Contents) 
            {
                concat += a;
            }
            foreach (char a in rhs) 
            {
                concat += a;
            }
            return concat;
        }

        public string Interleave(IEnumerable<char> rhs)
        {   
            var length = (rhs.Count() > Contents.Count()) ? Contents.Count() : rhs.Count(); 
            var conList = Contents.ToList();
            var rhsList = rhs.ToList();
            var inter = "";
            for (var i = 0; i < Contents.Count(); i++)
            {
                inter += conList[i];
                inter += rhsList[i];
            }
            return inter;
        }

        public string Print()
        {
            string print = "";
            foreach (char a in this.Contents) // Contents is a property in this class
            {
                print += a;
            }

            return print;
        }
    }
}
