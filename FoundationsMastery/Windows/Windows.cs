using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Windows
{
    public class Windows : Computer.Computer
    {
        public bool MadeOfPlastic { get; set; }

        public Windows()
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
    }
}
