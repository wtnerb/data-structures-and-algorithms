using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public void Render(string name)
        {
            Console.WriteLine($"This is the {name} tree");
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(Root);
            while (q.Peek() = null)
            {

            }
        }
    }
}
