using System;
using Hash_Table;
namespace repeated_word
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(RepeatedWord("this assingment is particularly obnoxious. Why are we doing this"));
            Console.WriteLine(RepeatedWord("act cat cat blue green"));
            Console.ReadKey();
        }

        public static string RepeatedWord (string text)
        {
            HashTable table = LoadHashTable(text);

            Node max = new Node("Map is empty", 0);
            foreach (Node buckett in table.Map)
            {
                Node current = buckett;
                while (current != null)
                {
                    if (current.Value > max.Value)
                    {
                        max = current;
                    }
                    current = current.Next;
                }
            }
            return max.Key;
        }

        public static HashTable LoadHashTable (string text)
        {
            HashTable table = new HashTable();
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (!table.Contains(word))
                {
                    table.Add(word, 1);
                }
                else
                {
                    int hash = table.Hash(word);
                    Node current = table.Map[hash];
                    while (current.Key != word)
                    {
                        current = current.Next;
                    }
                    current.Value++;
                }
            }
            return table;
        }
    }
}
