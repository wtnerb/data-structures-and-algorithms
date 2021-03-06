﻿using System;
using System.Collections.Generic;
using System.Text;

namespace multi_bracket_validation
{
    public class Node
    {
        public Node Next { get; set; } = null;
        public Node Prev { get; set; } = null;
        public int Value { get; set; }
        public Node (int value)
        {
            Value = value;
        }
    }
}
