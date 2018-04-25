using System;
using System.Collections.Generic;
using System.Text;

namespace K_aryTrees
{
    class Node<T>
    {
        public Node()
        {
            Children = new List<Node<T>>();
        }

        public Node (T value)
        {
            Children = new List<Node<T>>();
            Value = value;
        }

        public Node (T value, T[] children)
        {
            Children = new List<Node<T>>();
            foreach(T val in children)
            {
                Children.Add(new Node<T>(val));
            }
            Value = value;
        }

        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }
    }
}
