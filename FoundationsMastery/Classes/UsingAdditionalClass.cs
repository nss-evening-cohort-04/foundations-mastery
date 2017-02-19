using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Classes
{
    public class UsingAdditionalClass : AdditionalClass
    {
        public override string AdditionalClassDoesSomething(string saysSomethingElse)
        {
            saysSomethingElse = "Overrides what the AdditionalClass does";
            base.AdditionalClassDoesSomething(saysSomethingElse);
            return saysSomethingElse;
        }
    }
}
