using System;
using System.Collections.Generic;
using System.Text;

namespace Hash_Table
{
    public class Node
    {
        public string Key { get; set; }
        public Node Next { get; set; }
        public int Value { get; set; }

        public Node (string key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
