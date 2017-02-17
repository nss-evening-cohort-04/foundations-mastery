using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Parent
    {
        public string name { get; set; }

        public Parent()
        {
            
        }

        public virtual void EyeColor()
        {
            Console.WriteLine("blue eyes");
        }
    }
}
