using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class Cat : Animal
    {
        public bool Cares { get; } = false;
        public Cat(string name)
        {
            Name = name;
        }
    }
}
