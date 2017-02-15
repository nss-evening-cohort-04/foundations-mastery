using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Classes
{
    public class AdditionalClass
    {
        public virtual string AdditionalClassDoesSomething(string saysSomething)
        {
            saysSomething = "Something fun that the additional class does.";
            return saysSomething;
        }
    }
}
