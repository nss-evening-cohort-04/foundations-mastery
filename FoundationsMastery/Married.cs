using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    class Married : Couples
    {
        public string LastName { get; set; }

        public int Children { get; set; }

        public void setChildren()
        {
            Children = 0;
        }

        public override void SetCommitment()
        {
            Commitment = "for the long haul";
        }
        public bool Ring;

    }
}
