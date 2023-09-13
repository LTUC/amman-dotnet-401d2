using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableImplementation
{
    public class HashMap
    {

        // Buckets == a pre determined (size) array 
        // The map is an array of linkedlsit of type KeyValuePair

        
        public LinkedList<KeyValuePair<string, string>>[] Map { get; set; }

        public HashMap(int size)
        {
            Map = new LinkedList<KeyValuePair<string, string>>[size]; 
        }

        private int Hash(string key)
        {
            int hashValue = 0;

            char[] letters = key.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i]; /// Integer representation
            }

            //0 - 9
            hashValue = (hashValue * 599) % Map.Length;

            return hashValue;
        }

        public void Set(string key, string value)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] == null)
            {
                Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
            }

            KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);

            Map[hashKey].Insert(entry);

        }

        public void Print()
        {
            for (int i = 0; i < Map.Length; i++)
            {

                if (Map[i] == null)
                {
                    Console.WriteLine($"Bucket {i}: Empty");
                }

                else
                {
                    Console.WriteLine($"Bucket {i}");

                    Node<KeyValuePair<string, string>> current = Map[i].Head;

                    while (current != null)
                    {
                        Console.Write($"[{current.Value.Key}] : [{current.Value.Value}] =>");

                        current = current.Next;
                    }
                }
               
            }
        }

        public string Get(string key)
        {
            // What bucket this key in
            // Hash(key) wiil give us the index on the map



            // travrese the linkedlist (if it is there)
            // Examine the node one by pne and if the key we are looking for 
            // return the value

            return "";
        }

        public bool Has(string key)
        {
            // What bucket this key in
            // Hash(key) wiil give us the index on the map

            // travrese the linkedlist (if it is there)
            // Examine the node one by pne and if the key we are looking for 
            // return true/ false if we found it
            return true;
        }

    }
}
