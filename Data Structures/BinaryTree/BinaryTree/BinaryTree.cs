using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Recursively traverses the tree. In a Binary Search tree, this will return the nodes in order.
        /// </summary>
        /// <param name="source">the current node in the recursive traversal</param>
        public void InorderTraverse(Node source)
        {
            if (source.Left != null)
            {
                InorderTraverse(source.Left);
            }
            Console.WriteLine(source.Value);
            if (source.Right != null)
            {
                InorderTraverse(source.Right);
            }
        }

        //Overload starts traverse at root of tree to begin recursive traversal
        public void InorderTraverse()
        {
            InorderTraverse(Root);
        }

        public void PreorderTraverse (Node source)
        {
            Console.WriteLine(source.Value);
            if (source.Left != null)
            {
                PreorderTraverse(source.Left);
            }
            if (source.Right != null)
            {
                PreorderTraverse(source.Right);
            }
        }

        public void PreorderTraverse()
        {
            PreorderTraverse(Root);
        }

        public void PostorderTraverse(Node source)
        {
            Console.WriteLine(source.Value);
            if (source.Left != null)
            {
                PostorderTraverse(source.Left);
            }
            if (source.Right != null)
            {
                PostorderTraverse(source.Right);
            }
        }

        public void PostorderTraverse()
        {
            PreorderTraverse(Root);
        }


        public void Add(int value)
        {
            Node insertion = new Node
            {
                Value = value,
                Right = null,
                Left = null
            };
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(Root);
            while (q.Peek() != null)
            {
                Node temp = q.Dequeue();
                if (temp.Left != null)
                {
                    q.Enqueue(temp.Left);
                }
                else
                {
                    temp.Left = insertion;
                    return;
                }
                if (temp.Right != null)
                {
                    q.Enqueue(temp.Right);
                }
                else
                {
                    temp.Right = insertion;
                    return;
                }
            }

        }
    }
}
