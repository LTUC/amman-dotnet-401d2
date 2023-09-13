using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableImplementation
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }


        public LinkedList(){}

        public LinkedList(T value)
        {
            Node<T> node = new Node<T>(value);

            Head = node;
        }

        public void Insert(T value)
        {
            Node<T> node = new Node<T>(value);

            node.Next = Head;
            Head = node;
        }
    }
}
