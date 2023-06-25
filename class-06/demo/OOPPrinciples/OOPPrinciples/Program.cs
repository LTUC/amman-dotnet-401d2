using OOPPrinciples.Abstraction;
using OOPPrinciples.Encapsulation;
using OOPPrinciples.Inheritance;
using OOPPrinciples.Polymorphism;

using OOPPrinciples.Library;

namespace OOPPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            // BankAccount bankAccount = new BankAccount("111111", 4000, "Anas");

            //bankAccount. = -4000;

            //Car
            // OOPPrinciples.Inheritance.Car car = new OOPPrinciples.Inheritance.Car();
            //car.Year = 2019;

            //Cons

            // car.NumberOfDoors = 4;

            //Inheritance.Vehicle vehicle = new Inheritance.Vehicle();
            //vehicle.TurnRight();

            //OOPPrinciples.Inheritance.Car car = new OOPPrinciples.Inheritance.Car();

            //car.TurnRight();


            //Motorcycle motorcycle = new Motorcycle();

            //motorcycle.TurnRight();

            //motorcycle.Year = 2020;




            //// Polymorphism

            //List<Shape> shapes = new List<Shape>();

            //Circle circle = new Circle();

            //shapes.Add(circle);
            //shapes.Add(new Square());

            //foreach (Shape shape in shapes)
            //{
            //    shape.Draw();
            //}

            //Abstraction.Vehicle car = new Abstraction.Car();

            //car.Name;

            //car.Move();
            //car.Accelerate();
            //car.Brake();

            OOPPrinciples.Library.Library lib = new OOPPrinciples.Library.Library();

            //Adding books to the lib

            lib.AddBook(new FictionBook("Book1", "Author 1", 2005));
            lib.AddBook(new NonFictionBook("Book2", "Author 2", 2000));

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Display All Books");
                Console.WriteLine("2. Search by Title");
                Console.WriteLine("3. Search by Author");
                Console.WriteLine("4. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        lib.DisplayTheBooks();
                        break;
                    case 2:
                        Console.Write("Enter the title to search: ");
                        string title = Console.ReadLine();
                        lib.SearchByTitle(title);
                        break;
                    case 3:
                        Console.Write("Enter the author to search: ");
                        string author = Console.ReadLine();
                        lib.SearchByAuthor(author);
                        break;
               
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

    }
}
