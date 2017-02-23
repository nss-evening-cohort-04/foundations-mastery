using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Dachsund : Dog
    {
        public override string Length
        {
            get; set;
        }

        public override int Height
        {
            get; set;
        }

        public override string ColorOfFur
        {
            get; set;
        }

        public override int HasGrown
        {
            get
            {
                int newHeight = 1;

                int newerHeight = Height += newHeight;

                return newerHeight;
            }
            set
            {
            }
        }
    }
}
