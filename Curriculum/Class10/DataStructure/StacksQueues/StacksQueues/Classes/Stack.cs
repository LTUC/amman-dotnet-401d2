namespace StacksQueues.Classes
{
	class Stack
	{
		public Node Top { get; set; }

		public Stack(Node node)
		{
			Top = node;
		}

		/// <summary>
		/// Adding a node to the stack
		/// </summary>
		public void Push(Node node)
		{
			node.Next = Top;
			Top = node;
		}

		/// <summary>
		/// Remove an item from a stack
		/// </summary>
		/// <returns></returns>
		public Node Pop()
		{
			Node temp = Top;
			Top = Top.Next;
			temp.Next = null;
			return temp;
		}

		/// <summary>
		/// View the front item in the queue. 
		/// </summary>
		/// <returns></returns>
		public Node Peek()
		{
			return Top;
		}
	}
}
