using System;
using System.Collections.Generic;
using System.Text;

namespace multi_bracket_validation
{
    public class Stack
    {
        Node Head { get; set; } = null;

        /// <summary>
        /// Adds a node to the top of the stack
        /// </summary>
        /// <param name="node">Node to be added</param>
        public void Push(Node node)
        {
            node.Next = Head;
            Head = node;
        }


        /// <summary>
        /// Will return Node at top of stack or null if stack is empty
        /// </summary>
        /// <returns>Node or null</returns>
        public Node Pop()
        {
            try
            {
                Node top = Head;
                Head = Head.Next;
                return top;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the node at the top of the stack.
        /// </summary>
        /// <returns>the node at the top of the stack.</returns>
        public Node Peek()
        {
            return Head;
        }

        /// <summary>
        /// Prints the stack from top to bottom to the console
        /// </summary>
        public void Render()
        {
            Node current = Head;
            Console.Write("Head ");
            while (current != null)
            {
                Console.Write($"{current.Value} --> ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
