using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace StacksQueues.Classes
{
    class Node
    {
	    public int Value { get; set; }
	    public Node Next { get; set; }

	    public Node(int value)
	    {
		    Value = value;
	    }


    }
}
