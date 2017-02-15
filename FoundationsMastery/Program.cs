using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var Gordon = new Married();
            Gordon.Person1 = "Tara";
            Gordon.Person2 = "Debra";
            Gordon.LastName = "Gordon";
            Gordon.Children = 1;
            Gordon.Love = "forever love";
            Gordon.Commitment = "made for each other";
            Console.WriteLine($"The {Gordon.LastName}'s are married and have {Gordon.Children} child(ren). {Gordon.Person2} and {Gordon.Person1} have a {Gordon.Love}.");

        }
    }
}
