using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foundations Mastery Exercise");

            var showThatAdditionalClassIsWorking = new AdditionalClass();
            Console.WriteLine(showThatAdditionalClassIsWorking.AdditionalClassDoesSomething(""));

            var showThatUsingAdditionalClassIsWorking = new UsingAdditionalClass();
            Console.WriteLine(showThatUsingAdditionalClassIsWorking.AdditionalClassDoesSomething(""));

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
