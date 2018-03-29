﻿using System;
using System.Collections.Generic;
using System.Text;

namespace kth_from_end
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; } = null;

        public Node(int value)
        {
            Value = value;
        }

        public Node(int value, Node next)
        {
            Next = next;
            Value = value;
        }
    }
}
