using System;
using System.Collections.Generic;
using System.Text;

namespace Hash_Table
{
    public class HashTable
    {
        public Node[] Map { get; set; }

        public HashTable()
        {
            Map = new Node[4327];//moderately large prime number
        }

        public int Hash(string key)
        {
            int num = 0;
            foreach (char c in key.ToString())
            {
                num += c - 90;
            }

            return (int)num % Map.Length;
        }

        /// <summary>
        /// Adds a value to the hash table. Requires a key-value pair to be added to the table
        /// </summary>
        /// <param name="key">key of key-value pair</param>
        /// <param name="value">vlaue of key-value pair</param>
        public void Add (string key, string value)
        {
            int hash = Hash(key);
            Node addition = new Node(key, value);
            if (Map[hash] == null)
            {
                Map[hash] = addition;
            }
            else
            {
                Node current = Map[hash];
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = addition;
            }
        }

        /// <summary>
        /// Checks to see if anything with that key is contained in the map
        /// </summary>
        /// <param name="key">Key to check for existence</param>
        /// <returns>true if found, false if not</returns>
        public bool Contains (string key)
        {
            int hash = Hash(key);
            if (Map[hash] != null)
            {
                Node current = Map[hash];
                while (current.Key != key && current.Next != null)
                {
                    current = current.Next;
                }
                if (current.Key == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
