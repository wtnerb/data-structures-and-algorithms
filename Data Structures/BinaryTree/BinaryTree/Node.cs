using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
    }
}
