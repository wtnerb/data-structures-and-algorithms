using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Recursively traverses the tree. In a Binary Search tree, this will return the nodes in order.
        /// This one is private. It is called initially by the overload that will pass in Root and start the traversal.
        /// </summary>
        /// <param name="source">the current node in the recursive traversal</param>
        private void InorderTraverse(Node source)
        {
            if (source.Left != null)
            {
                InorderTraverse(source.Left);
            }
            Console.Write($"{source.Value}, ");
            if (source.Right != null)
            {
                InorderTraverse(source.Right);
            }
        }

        //Overload starts traverse at root of tree to begin recursive traversal
        //This overload is the only public facing overload.
        public void InorderTraverse()
        {
            InorderTraverse(Root);
            Console.WriteLine();
        }

        //see InorderTraverse comments
        private void PreorderTraverse (Node source)
        {
            Console.Write($"{source.Value}, ");
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
            Console.WriteLine();
        }

        private void PostorderTraverse(Node source)
        {
            if (source.Left != null)
            {
                PostorderTraverse(source.Left);
            }
            if (source.Right != null)
            {
                PostorderTraverse(source.Right);
            }
            Console.Write($"{source.Value}, ");
        }

        public void PostorderTraverse()
        {
            PostorderTraverse(Root);
            Console.WriteLine();
        }

        /// <summary>
        /// Adds a leaf to the tree. It will add a leaf to the highest, leftmost (in that order) open position.
        /// </summary>
        /// <param name="value">value to be added</param>
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
