using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class CoolCustomString : CustomString
    {
        public CoolCustomString(char[] arg) : base(arg)
        {
        }

        public override IEnumerable<char> Contents
        {
            get
            {
                return _customString;
            }

            set
            {
                _customString = value;
            }
        }

        public override string Concat(IEnumerable<char> rhs)
        {
            return string.Concat(rhs.Concat(Contents).TakeWhile(char.IsLetter));
        }

    }
}
