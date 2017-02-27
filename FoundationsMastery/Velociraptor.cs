using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Velociraptor : Dinosaur
    {
        public bool isCarnivore { get; set; }
        public int runningSpeed { get; set; }


        public Velociraptor(string name)
        {
            base.Name = name;
        }

        public override void DinoVocalization()
        {
            Console.Write("*chatter*");
        }

     }
 }

