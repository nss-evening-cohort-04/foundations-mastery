using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery;

namespace FoundationsMastery
{
    public class WindowsComputer : Computer
    {
        public override void Functionality()
        {
            Console.WriteLine("I love to ruin your life with errors that force me to restart!");
        }

        public override bool Shutdown()
        {
            Console.WriteLine("Hope you've saved everything!");
            System.Threading.Thread.Sleep(1000);
            return true;
        }
    }
}
