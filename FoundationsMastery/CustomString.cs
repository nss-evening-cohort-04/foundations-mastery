using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class CustomString : Interfaces.ICustomString
    {
        

        public CustomString()
        {
            //can i have an empty constructor?
           //CustomString customString = new CustomString();
        }

        public CustomString(IEnumerable<char> contents)
        {

            this.Contents = contents; //setting contents passed in, inheriting from interface Contents
        }

        public IEnumerable<char> Contents {get; set;}

        public int Length
        {
            get
            {
                return this.Contents.Count();
            }
                
         } //gets the length



        public void Clear()
        {
            Contents.ToList().Clear();
        }

        public string Concat(IEnumerable<char> rhs)
        {
            
            var concatted = Contents.Concat(rhs);
            concatted.GetEnumerator();
            return concatted.ToString();
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
