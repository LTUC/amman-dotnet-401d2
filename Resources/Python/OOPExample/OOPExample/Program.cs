using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using OOPExample.Classes;
using OOPExample.Classes.Example1;
using OOPExample.Classes.Example3;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            InheritanceExample();
            PythonEncapsExample();
            PolymorphismAbstractExample();
        }

        static void InheritanceExample()
        {
            // C# Inheritance example
            // C# example to match Python class structure
            // instantiating objects
            Dog mikey = new Dog("Mikey", 6);

            Console.WriteLine(mikey.Description());
            Console.WriteLine(mikey.Speak("Gruff Gruff"));

            Console.WriteLine();
            GoldenDoodle sawyer = new GoldenDoodle() { Name = "Sawyer", Age = 4 };
            Console.WriteLine(sawyer.Description());
            Console.WriteLine(sawyer.Speak("Woof Woof"));
            Console.WriteLine(sawyer.Species);

            Console.WriteLine();
            RussellTerrier princess = new RussellTerrier() { Name = "princess", Age = 8 };

            Console.WriteLine(princess.Description());
            Console.WriteLine(princess.Speak("Hello Peasants"));
            Console.WriteLine(princess.Species);
        }

        static void PythonEncapsExample()
        {
            List<string> books = new List<string> { "Magical Me", "Fantastic Beasts and where to find them", "Hogwarts, a history", "Year with the Yeti" };

            Library library = new Library(books);

            Customer customer = new Customer();

            while (true)
            {
                Console.WriteLine("Enter 1 to display the available books");
                Console.WriteLine("Enter 2 to request for a book");
                Console.WriteLine("Enter 3 to return a book");
                Console.WriteLine("Exit");
                int userchoice = Convert.ToInt16(Console.ReadLine());
                switch (userchoice)
                {
                    case 1:
                        library.DisplayAvailableBooks();
                        break;
                    case 2:
                        string requestedBook = customer.RequestBook();
                        library.LendBook(requestedBook);
                        break;
                    case 3:
                        string returnedBook = customer.RequestBook();
                        library.AddBook(returnedBook);
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }

        static void PolymorphismAbstractExample()
        {
            Document[] documents = new Document[]
            {
                new PDF(){Name="Document1"},
                new PDF(){Name="Document2"},
                new Word(){Name="Document3"},
            };

            for (int i = 0; i < documents.Length; i++)
            {
                Console.WriteLine($"{documents[i].Name} : {documents[i].Show()}");
            }

        }
    }
}
