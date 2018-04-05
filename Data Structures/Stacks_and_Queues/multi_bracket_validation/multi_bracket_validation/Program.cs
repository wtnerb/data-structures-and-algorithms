using System;

namespace multi_bracket_validation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool Magic (string s)
        {
            Stack bracks = new Stack();
            try
            {
                foreach (char ch in s)
                {
                    switch (ch)
                    {
                        // if an open bracket is found, add to stack
                        case '(':
                            bracks.Push(new Node(1));
                            break;
                        case '[':
                            bracks.Push(new Node(2));
                            break;
                        case '{':
                            bracks.Push(new Node(3));
                            break;

                        // if a close bracket is found, check statck. If it does not match, return false.
                        case ')':
                            if (bracks.Pop().Value != 1)
                                return false;
                            break;
                        case ']':
                            if (bracks.Pop().Value != 2)
                                return false;
                            break;
                        case '}':
                            if (bracks.Pop().Value != 3)
                                return false;
                            break;
                        // ignore everything that is not a bracket.
                        default:
                            break;
                    }
                }
            }
            catch
            {
                // only exception to be throw: null reference when poping an empty stack
                // in that case, a bracket was opened before it was closed and is invalid.
                return false;
            }
            if (bracks.Peek() != null)
                return false;
            // if we have cycled through and nothing causes a fail, call it valid.
            return true;
        }
    }
}
