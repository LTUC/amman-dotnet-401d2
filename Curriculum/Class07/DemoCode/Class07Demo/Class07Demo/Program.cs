using Class07Demo.Classes;
using System;

namespace Class07Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Library<string> library = new Library<string>();

            library.Add("Harry Potter");
            library.Add("Horton Hears a Who");
            library.Add("Hunger Games");

            foreach (var item in library)
            {
                Console.WriteLine(item);
            }


            
            Library<string> secondLib = new Library<string>
            {
                "The Great Gatsby",
                "Where the Red Fern Grows",
                "Of Mice and Men"
            };
        }
    }
}
