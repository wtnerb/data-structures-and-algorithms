using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public virtual byte Legs { get; set; } = 4;
    }
}
