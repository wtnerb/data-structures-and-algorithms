using System.Collections.Generic;

namespace K_aryTrees
{
    public class Tree<T>
    {
        // Constructors:
        public Tree(Node<T> root)
        {
            Root = root;
        }

        public Tree(T rootValue)
        {
            Root = new Node<T>() { Value = rootValue };
        }

        //Properties:
        public Node<T> Root { get; set; }

        public delegate void Method(Node<T> n);


        //Methods:
        //Traverse recursively applying a method before traversal
        public void PreOrderTraverse(Method func)
        {
            func(Root);
            foreach (Node<T> n in Root.Children)
            {
                Tree<T> t = new Tree<T>(n);
                t.PreOrderTraverse(func);
            }
        }

        //Traverse recursively applying a method after traversal
        public void PostOrderTraverse(Method func)
        {
            foreach (Node<T> n in Root.Children)
            {
                Tree<T> t = new Tree<T>(n);
                t.PreOrderTraverse(func);
            }
            func(Root);
        }

        //Traverse across a row applying a method to each item in the row. After a row is complete, move on.
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

        //Search breadth first for the first node of value 'target'. Then add a new node of value 'addition' to the list of children.
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
