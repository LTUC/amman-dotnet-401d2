using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class10_demo.Stack
{
    public class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        public bool IsEmpty()
        {
           // if (top == null) { return true} else { return false; }
            return top == null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int data = top.Data;
            top = top.Next;
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return top.Data;
        }
    }
}
