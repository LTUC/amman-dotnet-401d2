using System.Collections.Generic;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Boxing & UnBoxing

            int number = 40;
            object boxedNumber = number; // Boxing ocuurs here


            object boxedNumber2 = 40;
            int number2 = (int)boxedNumber2; // Unboxing occurs here

            //ObjectList list = new ObjectList();

            //list.Add(42);


            // Using of our Custome Generic List

            GenericList<int> numbersGenericList = new GenericList<int>();

            

            numbersGenericList.Add(10);

            numbersGenericList.Add(20);

            numbersGenericList.Add(30);


            //Console.WriteLine(numbersGenericList[0]);
      

            GenericList<Book> genericListOfBooks = new GenericList<Book>();

            genericListOfBooks.Add(new Book() { Title = "C# books" });


            //var book = new Book() { Title = "Book 1"};

            //var numbers = new List();

            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);



            //************* Collections from DotNet
            ListExample();

            DictionaryExample();
        }


        public static void ListExample()
        {

            // Create a vriable called family using a list of string 
            //By create new instance of List collection with type string
            List<string> family = new List<string>();

            family.Add("Anas");
            family.Add("Osama");
            family.Add("Ahmad");

            foreach (string person in family)
            {
                Console.WriteLine($"{person}"); 
            }

            List<int> numbers = new List<int> { 4, 6, 8 };

            foreach (int number in numbers)
            {
                Console.WriteLine($"{number} * {number} = {number * number}");
            }


        }

        public static void DictionaryExample()
        {
            Dictionary<string, int> grades = new Dictionary<string, int>();


            grades.Add("Anas", 95);
            grades.Add("Ala'a", 95);
            grades.Add("Yaman", 90);

            Console.WriteLine($"grade of the first student {grades["Anas"]}");
            Console.WriteLine(grades.Count);

            foreach (var item in grades.Keys)
            {
                Console.WriteLine(item);
            }

            // Console.WriteLine(grades.Values);

            foreach (KeyValuePair<string, int> student in grades)
            {
                Console.WriteLine("Key: {0}, value {1}", student.Key, student.Value);

            }

        }
    }
}