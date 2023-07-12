using System.Collections;

namespace Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Circle circle = new Circle();

            //circle.Method(5);

            //ShoppingCart cart = new ShoppingCart();
            //cart.AddItem("Apple");
            //cart.AddItem("Banana");
            //cart.AddItem("Orange");


            //foreach (string item in cart)
            //{
            //    Console.WriteLine(item);
            //}
            //int x = 3;
            //Add(ref x);
            //Console.WriteLine(x);

            //string number = "ssss";

            //var parse = int.TryParse(number, out int intNumber);

            //Console.WriteLine(parse);
            //Console.WriteLine(intNumber);

            string post = "This is supposed to be a very long post";

            // ="This post supposed to ....";
            // 

            string shortString = post.Short(5);

            Console.WriteLine(shortString + "....");

            const int MaxVAlue = 100;
        }

        public static void Add(ref int x)
        {
            x = x + 3;
        }
    }



    public static class StringExtensions
    {
        public static string Short(this String str, int numberOfWords)
        {
            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
            {
                return str;
            }

            var shortString = string.Join(" ", words.Take(numberOfWords));

            return shortString;
        }

    }


    public class Circle
    {

        public int Method(int a)
        {
            return a;

        }
        public int Method(int a, int b)
        {
            return b + a;
        }

        public static float PI { get; set; }

        public Circle()
        {

        }

        static Circle()
        {
            PI = 3.14f;
        }
    }

    public class ShoppingCart : IEnumerable<string>
    {
        private List<string> items = new List<string>();
        public void AddItem(string item)
        {
            items.Add(item);
        }


        public IEnumerator<string> GetEnumerator()
        {
            return items.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public virtual void DisplayName()
        {
            Console.WriteLine(this.Name);
        }
    }

    public class Student : Person
    {
        public int Grade { get; set; }

        public sealed override void DisplayName()
        {
            Console.WriteLine($"Student name {this.Name}");
        }


         
    }

}