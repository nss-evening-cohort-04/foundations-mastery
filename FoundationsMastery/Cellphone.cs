using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Cellphone
    {
        public bool Touchscreen { get; set; }
        public int MemoryGB { get; set; }
        public string Model { get; set; }

        public Cellphone()
        {
            this.MemoryGB = 0;
        }

        public Cellphone(int memory, bool screen, string model)
        {
            Touchscreen = screen;
            MemoryGB = memory;
            Model = model;
        }

        public virtual string OperatingSystem()
        {
            var OS = "Operating System used:";
            return OS;
        }

        public virtual int MemoryRecall()
        {
            Console.WriteLine("Total Memory: 0GB");
            return MemoryGB;
        }
    }
}
