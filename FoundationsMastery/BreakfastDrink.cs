using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class BreakfastDrink
    {
        public string Caffeine { get; set; }
        public string Juice { get; set; }
        
        public virtual void defaultCaffeine()
        {
            string coffee = "I'll have coffee.";
        }

        public virtual void defaultJuice()
        {
            string juice = "Orange Juice.";
        }
    }
}
