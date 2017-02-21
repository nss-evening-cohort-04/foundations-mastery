using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Car : Truck
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public virtual void FuelType()
        {
            Console.WriteLine("Gas");
        }
        
       }
    public class Deisel : Car
    {
        public override void FuelType()
        {
            Console.WriteLine("Deisel");
        }

    }
}
