using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        // In order to make traversals testable, had to refactor to use delegate
        public delegate void Delegate(Node<T> n);

        /// <summary>
        /// Recursively traverses the tree. In a Binary Search tree, this will return the nodes in order.
        /// This one is private. It is called initially by the overload that will pass in Root and start the traversal.
        /// </summary>
        /// <param name="source">the current node in the recursive traversal</param>
        private void InorderTraverse(Node<T> source, Delegate lambda)
        {
            if (source.Left != null)
            {
                InorderTraverse(source.Left, lambda);
            }
            lambda(source);
            if (source.Right != null)
            {
                InorderTraverse(source.Right, lambda);
            }
        }

        //Overload starts traverse at root of tree to begin recursive traversal
        //This overload is the only public facing overload.
        public void InorderTraverse(Delegate lambda)
        {
            InorderTraverse(Root, lambda);
        }

        //see InorderTraverse comments
        private void PreorderTraverse (Node<T> source, Delegate lambda)
        {
            lambda(source);
            if (source.Left != null)
            {
                PreorderTraverse(source.Left, lambda);
            }
            if (source.Right != null)
            {
                PreorderTraverse(source.Right, lambda);
            }
        }

        public void PreorderTraverse(Delegate lambda)
        {
            PreorderTraverse(Root, lambda);
        }

        private void PostorderTraverse(Node<T> source, Delegate lambda)
        {
            if (source.Left != null)
            {
                PostorderTraverse(source.Left, lambda);
            }
            if (source.Right != null)
            {
                PostorderTraverse(source.Right, lambda);
            }
            lambda(source);
        }

        public void PostorderTraverse(Delegate lambda)
        {
            PostorderTraverse(Root, lambda);
        }

        /// <summary>
        /// Adds a leaf to the tree. It will add a leaf to the highest, leftmost (in that order) open position.
        /// </summary>
        /// <param name="value">value to be added</param>
        public void Add(T value)
        {
            Node<T> insertion = new Node<T>
            {
                Value = value,
                Right = null,
                Left = null
            };
            Queue<Node<T>> q = new Queue<Node<T>>();
            q.Enqueue(Root);
            while (q.Peek() != null)
            {
                Node<T> temp = q.Dequeue();
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
