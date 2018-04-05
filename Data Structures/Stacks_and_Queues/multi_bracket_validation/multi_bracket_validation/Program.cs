using System;

namespace multi_bracket_validation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "This string (should) pass.",
                           "This one )should( fail.",
                           "this one is ([Tricky)] but should fail",
                           "Square[<] and {cur}ly brackets count but > angle brackets don't"
                           };
            foreach (string s in strings)
            {
                Console.WriteLine($"{s} ... Thinking ... valid = {Magic(s)}");
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
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
                // only exception should be 'null reference' when popping an empty stack
                // in that case, a bracket was closed before it was opened and is invalid.
                return false;
            }
            if (bracks.Peek() != null)
                //if there are lingering unclosed brackets, invalid
                return false;
            // if no failing conditions have been found, it must be valid
            return true;
        }
    }
}
