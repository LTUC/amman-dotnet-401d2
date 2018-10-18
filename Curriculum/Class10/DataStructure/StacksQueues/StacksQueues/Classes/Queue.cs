namespace StacksQueues.Classes
{
	class Queue
	{
		public Node Front { get; set; }
		public Node Rear { get; set; }
		public Queue(Node node)
		{
			Front = node;
			Rear = node;
		}

		public void Enqueue(Node node)
		{
			node.Next = Rear;
			Rear = node.Next;
		}

		public Node Dequeue(Node node)
		{
			Node temp = Front;
			Front = Front.Next;
			temp.Next = null;

			return temp;
		}

		public Node Peek()
		{
			return Front;
		}


	}
}
