using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class Node
    {
        public Node Next { get; set; } = null;
        public Node Prev { get; set; } = null;
        public Animal Value { get; set; }
        public Node (Animal value)
        {
            Value = value;
        }
    }
}
