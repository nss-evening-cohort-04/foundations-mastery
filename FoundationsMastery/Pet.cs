﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class Pet 
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public void setName()
        {
            Name = "Rocky";
        }

        public void setAge()
        {
            Age = 1;
        }
        public virtual void setType()
        {
            Type = "Leopard Gecko";
        }
    }
}
