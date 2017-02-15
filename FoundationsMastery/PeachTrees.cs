using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class PeachTrees : Trees
    {
        public PeachTrees()
        {
            height = 8;
        }
        public override void grow(double growth)
        {
            height = height + growth + 1.2; 

        }
    }
}
