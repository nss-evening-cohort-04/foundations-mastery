using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery;

namespace FoundationsMastery
{
    public class WindowsOS : Computer
    {
        public bool MadeOfPlastic { get; set; }

        public WindowsOS()
        {
            ProcessType = "I7";
            MadeOfPlastic = true;
        }
        // Method override
        public override string OsType()
        {
            return OS = "Windows";
        }
        // Method override and overload
        public override string OsType(string os)
        {
            return OS = os;
        }

        public int NumOfCores(int cores)
        {

            return ProcessCores = cores;
        }

        // Reverse a string for the fun of it.
        public string ReverseString(string reverseMe)
        {
            char[] charArray = reverseMe.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
