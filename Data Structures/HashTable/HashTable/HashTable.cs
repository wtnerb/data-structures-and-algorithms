using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class HashTable<T>
    {
        public Node<T>[] Map { get; set; }

        public HashTable()
        {
            Map = new Node<T>[5000];
        }

        public int Hash(T val)
        {
            int n = 0;
            long num = 0;
            if (val is string)
            {
                foreach (char c in val.ToString())
                {
                    n++;
                    num += c - 90 + F(n);
                }
            }
            if (val is int)
            {
                num = (int)val;
            }

            return (int)num % Map.Length;
        }

        public int F(int number)
        {
            
        }
    }
}
