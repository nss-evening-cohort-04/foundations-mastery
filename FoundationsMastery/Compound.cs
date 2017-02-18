using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Compound : Bow
    {

        public Compound()
        {
            NumberOfCams = 2;
        }

        public Compound(int fps)
        {
            FPS = fps;
        }

        public override string ProduceStringMusic()
        {
            return "Arrow goes pew pew really fast and makes beautiful string music";
        }
    }
}
