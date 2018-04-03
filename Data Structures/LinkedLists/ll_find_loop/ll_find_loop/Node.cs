using System;

namespace ll_find_loop
{
    public class Node
    {
	    public Node(int value)
	    {
            Value = value;
            Next = null;
	    }

        public int Value { get; set; }
        public Node Next { get; set; }
    }
}
