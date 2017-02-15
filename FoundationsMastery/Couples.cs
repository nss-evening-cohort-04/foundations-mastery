using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    class Couples
    {
        public string Person1 { get; set; }
        public string Person2 { get; set; }
        public string Love { get; set; }
        public string Commitment { get; set; }
        public void SetLove()
        {
            Love = "strong";
        }
        public virtual void SetCommitment()
        {
            Commitment = "who knows";
        }
    }
}
