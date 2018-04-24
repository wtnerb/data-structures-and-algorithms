using System;
using System.Collections.Generic;
using System.Text;

namespace KaryTrees
{
    class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }
    }
}
