using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Samsung : Cellphone
    {
        public Samsung(int memory, bool screen, string model)
        {
            Touchscreen = screen;
            MemoryGB = memory;
            Model = model;
        }

        public override string OperatingSystem()
        {
            var OS = "Operating System used: Android";
            return OS;
        }

        public override int MemoryRecall()
        {
            Console.WriteLine($"Total Memory: {MemoryGB}GB");
            return MemoryGB;
        }
    }
}
