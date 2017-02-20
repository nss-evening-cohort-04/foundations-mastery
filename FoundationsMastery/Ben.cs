using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Ben : Pet
    {
        public string Home { get; set; }

        public int Friends { get; set; }

        public void setNoise()
        {
            Noisey = true;
        }

        public override  setFood()
        {
            Food = "Kibble";
        }
    }
}
