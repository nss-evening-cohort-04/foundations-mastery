using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Dinosaur
    {
        //Attributes common to all dinosaurs
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }


        //Virtual method to override in child class
        public virtual void DinoVocalization()
        {
            Console.Write("ROAR");
        }
        
    }
}
