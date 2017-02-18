using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class BreakfastAlternative : BreakfastDrink
    {
        public override void defaultCaffeine()
        {
            string tea = "I'll have tea instead";
        }

        public override void defaultJuice()
        {
            string grapefruit = "Grapefruit Juice.";
        }
    }
}
