namespace LinkedListImplemetation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();

            // Adding elements
            myList.AddToTheLast(10);

            myList.AddToTheLast(20);

            myList.AddToTheLast(30);

            Console.WriteLine("Elements in the list");

           // Console.WriteLine(myList.head.Data);

            Node currentNode = myList.head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }

            // Insert a new element at position 1
            myList.InsertAt(15, 1);

            Console.WriteLine("Elments in the linked list after insetion");

            Node currentNode2 = myList.head;

            while (currentNode2 != null)
            {
                Console.WriteLine(currentNode2.Data);
                currentNode2 = currentNode2.Next;
            }

        }
    }

    public class Node
    {
        public int Data { get; set; }

        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node head { get; set; }
        public Node tail { get; set; }

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddToTheLast(int data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                
                tail.Next = newNode;

                tail = newNode;
            }
        }


        // AddFirst, InsertAt, Remove

        public void InsertAt(int data, int position)
        {
            Node newNode = new Node(data);
            Node previousNode = null;
            Node currentNode = head;
            int currentPostion = 0;

            while(currentNode != null && currentPostion < position) 
            {
                previousNode = currentNode;
                currentNode = currentNode.Next; 
                currentPostion++;

            }

            if(currentPostion == position)
            {
                previousNode.Next = newNode;
                newNode.Next = currentNode;

                if (currentNode == null)
                {
                    tail = newNode;
                }
            }
            else
            {
                Console.WriteLine("Posion out of range.");
            }
        }
    }
}