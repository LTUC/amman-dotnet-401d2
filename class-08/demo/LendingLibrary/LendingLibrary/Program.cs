namespace LendingLibrary
{
    class Program
    {
        private static readonly Library library = new Library();
        private static readonly Backpack<Book> bookBag = new Backpack<Book>();

        static void Main(string[] args)
        {
            LoadBooks();
            UserInterface();
        }

        public static List<int> GetEvenNumbers(int count)
        {
            var evenNumbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if(i % 2 == 0)
                {
                    evenNumbers.Add(i); // Add the current value of 'i' to the list if it even number
                }
            }

            return evenNumbers;
        }

        public static IEnumerable<int> GetEvenNumbersWithYield(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i; // yield 'or return the current valie of i'
                }
            }
        }


        static void UserInterface()
        {
            while (true)
            {
                Console.WriteLine("WELCOME to the lending library!");
                Console.WriteLine("pick an option...");
                Console.WriteLine("1. View All Books");
                Console.WriteLine("2. Add New Book");
                Console.WriteLine("3. Borrow a Book");
                Console.WriteLine("4. Return a Book");
                Console.WriteLine("5. View Book Bag");
                Console.WriteLine("6. Exit");
                Console.WriteLine();

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Library");
                        Console.WriteLine("=======");
                        OutputBooks(library);
                        break;
                    case "2":
                        Console.Clear();
                        AddBook();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        BorrowBook();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        ReturnBook();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Book Bag");
                        Console.WriteLine("========");
                        OutputBooks(bookBag);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option...");
                        Console.WriteLine();
                        break;
                }
            }
        }

        static void LoadBooks()
        {
            library.Add("Alice in Wonderland", "Lewis", "Carol", 146);
            library.Add("The Great Gatsby", "F. Scott", "Fitzgerald", 218);
            library.Add("To Kill a Mockingbird", "Harper", "Lee", 281);
            library.Add("Lord of the Flies", "William", "Golding", 224);
        }

        static void OutputBooks(IEnumerable<Book> books)
        {
            int counter = 1;
            foreach (Book book in books)
            {
                Console.WriteLine($"{counter++}. {book}");
            }
            Console.WriteLine();
        }

        private static void AddBook()
        {
            Console.WriteLine("Please enter the following details:");
            Console.Write("Book Title: ");
            string title = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Author First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Author Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Number Of Pages: ");
            string numberOfPages = Console.ReadLine();


            int.TryParse(numberOfPages, out int result);

            library.Add(title, firstName, lastName, result);
        }

        private static void BorrowBook()
        {
            foreach (Book book in library)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();
            Console.WriteLine("Which book would you like to borrow?");

            string selection = Console.ReadLine();
            Book borrowed = library.Borrow(selection);
            bookBag.Pack(borrowed);
        }

        static void ReturnBook()
        {
            OutputBooks(bookBag);

            Console.WriteLine("Which book would you like to return?");

            int selection = Convert.ToInt32(Console.ReadLine());
            Book bookToReturn = bookBag.Unpack(selection - 1);
            library.Return(bookToReturn);
        }
    }
}