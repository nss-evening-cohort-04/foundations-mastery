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

            int x = 0;

            while (true)
            {
                Console.WriteLine($"[{x}]>");
                // increment number of times using program
                x++;
                // user passed expression
                string input = Console.ReadLine();
                if (input.ToLower() == "quit" || input.ToLower() == "exit")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
            }
        }
    }
}
