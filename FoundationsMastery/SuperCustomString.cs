using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    class SuperCustomString: CustomString
    {
        public SuperCustomString (char [] userPassedArray) : base(userPassedArray)
        {

        }

        public override void Clear()
        {
            base.Clear();
        }
    }
}
