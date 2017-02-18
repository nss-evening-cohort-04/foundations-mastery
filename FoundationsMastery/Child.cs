using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Child : Parent
    {
        public Child()
        {
            name = "Nathan Jr.";
        }
        public override void EyeColor()
        {
            base.EyeColor();
            Console.WriteLine("Brown eyes");
        }
    }
}
