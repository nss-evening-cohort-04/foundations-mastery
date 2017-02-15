using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Computer
{
    public class Computer
    {
        public string ProcessType { get; set; }
        public int ProcessCores { get; set; }
        public bool HasTouchPad { get; set; }
        public int RamAmount { get; set; }
        public string OS { get; set; }
        
        public Computer()
        {
            RamAmount = 2;
        }
        // Method overloading
        public Computer(int amountOfRam)
        {
            RamAmount = amountOfRam;
        }

        // virtual method will be overridden in Windows.cs
        public virtual string OsType()
        {
            return OS = "Linux";
        }
        // Method Overloading 
        public virtual string OsType(string ostype)
        {
            return OS = ostype;
        }

    }
}
