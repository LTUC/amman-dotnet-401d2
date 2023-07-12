namespace Class10_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Console.WriteLine(FactorialWithoutRecursion(5));

            //Console.WriteLine(FactorialWithRecursion(5));

            Class10_demo.Stack.Stack stack = new Class10_demo.Stack.Stack();

            // pushin books numbers onto the stack

            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
            stack.Push(11);

            // Checking if the stack is empty
            bool isEmpty = stack.IsEmpty();
            Console.WriteLine(isEmpty);

            // Peek the top element
            var topElement = stack.Peek();

            Console.WriteLine($"The top element of the stack is {topElement}");

            // Pop the top element
            int poppedElement = stack.Pop();
            int poppedElement2 = stack.Pop();

            Console.WriteLine($"Popped element from the stak is {poppedElement}");
            Console.WriteLine($"secound Popped element from the stak is {poppedElement2}");

            // Peek the top element
            var newTopElement = stack.Peek();

            Console.WriteLine($"The top element of the stack is {newTopElement}");

            stack.Push(25);

            // Peek the top element
            var newTopElement2 = stack.Peek();

            Console.WriteLine($"The top element of the stack is {newTopElement2}");


        }

        public static int FactorialWithoutRecursion(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int FactorialWithRecursion(int n)
        {
            /// Base of Recursion
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * FactorialWithRecursion(n - 1);
            }
        }
    }
}