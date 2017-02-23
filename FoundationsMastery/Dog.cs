using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{

    
    public class Dog
    {
        public virtual string Length
        {
            get; set;
        }

        public virtual int Height
        {
            get; set;
        }

        public virtual string ColorOfFur
        {
            get; set; 
        }

        public virtual int HasGrown
        {
            get; set;
        }
    }
}
