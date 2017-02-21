using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Pets
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Weight { get; set; }

        public int Cuteness { get; set; }

        public virtual void FoodAmount()
        {
            Console.WriteLine("I need to eat");
        }

        public virtual void WaterAmount()
        {
            Console.WriteLine("I'm so thirsty!");
        }
    }
}
