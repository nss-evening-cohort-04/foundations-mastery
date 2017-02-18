using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Bow
    {

        public int NumberOfCams { get; set; }
        public int FPS { get; set; }

        public Bow()
        {
            NumberOfCams = 0;
            FPS = 100;
        }

        public Bow(int numberOfCams)
        {
            if( numberOfCams >= 0)
            {
                NumberOfCams = numberOfCams;
            }
            else
            {
                throw new ArgumentException("Must set a positive number of cams");
            }           
        }
        
        public virtual string ProduceStringMusic() {
            return "Arrow goes pew pew and makes some music";
        }
    }
}
