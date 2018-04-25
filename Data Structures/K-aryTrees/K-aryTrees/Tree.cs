using System.Collections.Generic;

namespace K_aryTrees
{
    public class Tree<T>
    {
        public Tree(Node<T> root)
        {
            Root = root;
        }

        public Tree(T rootValue)
        {
            Root = new Node<T>() { Value = rootValue };
        }

        public Node<T> Root { get; set; }

        public delegate void Method(Node<T> n);

        public void PreOrderTraverse(Method func)
        {
            func(Root);
            foreach (Node<T> n in Root.Children)
            {
                Tree<T> t = new Tree<T>(n);
                t.PreOrderTraverse(func);
            }
        }

        public void PostOrderTraverse(Method func)
        {
            foreach (Node<T> n in Root.Children)
            {
                Tree<T> t = new Tree<T>(n);
                t.PreOrderTraverse(func);
            }
            func(Root);
        }

        public void BreadthFirstTraverse(Method func)
        {
            Queue<Node<T>> q = new Queue<Node<T>>();
            q.Enqueue(Root);
            Node<T> current;
            while (q.TryDequeue(out current))
            {
                func(current);
                foreach (Node<T> n in current.Children)
                {
                    q.Enqueue(n);
                }
            }
        }

        public void Add(T target, T addition)
        {
            bool added = false;
            void AddConditionally(Node<T> current)
            {
                if (!added && current.Value.Equals(target))
                {
                    current.Children.Add(new Node<T> { Value = addition });
                    added = true;
                }
            }
            BreadthFirstTraverse(AddConditionally);
        }
    }
}
