using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Trees
    {
        public Trees()
        {
            height = 10;
        }
        protected double _height;
        public double height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public virtual void grow(double growth)
        {
            height += growth;
        }
    }
}
