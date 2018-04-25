using System.Collections.Generic;

namespace K_aryTrees
{
    public class Node<T>
    {
        //Constructors:
        //Improved default constructor - otherwise using list methods breaks things
        public Node()
        {
            Children = new List<Node<T>>();
        }

        //Constructor with a value
        public Node (T value)
        {
            Children = new List<Node<T>>();
            Value = value;
        }

        //Constructor with array of values for children
        public Node (T value, T[] children)
        {
            Children = new List<Node<T>>();
            foreach(T val in children)
            {
                Children.Add(new Node<T>(val));
            }
            Value = value;
        }

        //Properties:
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }
    }
}
