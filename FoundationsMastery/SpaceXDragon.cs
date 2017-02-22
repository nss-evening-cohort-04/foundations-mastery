using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class SpaceXDragon : SpaceCraft
    {
        public SpaceXDragon()
        {
            Name = "Dragon";

        }

        //virtual override method.
        public override string FlySpaceCraft()
        {
            return "bbbbbbbblllllllllllassssssssssstttttttooooooooffffffff!!!!!!";
        }

        //virtual override property.
        public override int NumberOfEngines
        {
            get
            {
                return NumberOfEngines;
            }

            set
            {
                base.NumberOfEngines = 9;
            }
        }
    }
}
