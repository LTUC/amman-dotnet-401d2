namespace TreeDS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySeartchTree<int> binarySeartchTree = new BinarySeartchTree<int>();

            binarySeartchTree.Add(50);
            binarySeartchTree.Add(30);
            binarySeartchTree.Add(70);
            binarySeartchTree.Add(20);
            binarySeartchTree.Add(40);
            binarySeartchTree.Add(60);
            binarySeartchTree.Add(80);


            Console.WriteLine("Pre-Order Traversal");

            string resultString = string.Join(",", binarySeartchTree.PreOrderTravarsel());
            Console.WriteLine(resultString);


            Console.WriteLine("In-order Traversal");
            Console.WriteLine(string.Join(", ", binarySeartchTree.InorderTraversal()));

            Console.WriteLine("Post-order Traversal");
            Console.WriteLine(string.Join(", ", binarySeartchTree.PostorderTraversal()));


        }
    }
}