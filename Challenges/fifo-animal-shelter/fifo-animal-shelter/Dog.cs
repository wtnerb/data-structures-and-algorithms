using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class Dog : Animal
    {
        public bool IsAGoodDog { get; } = true;
        public Dog(string name)
        {
            Name = name;
        }
    }
}
