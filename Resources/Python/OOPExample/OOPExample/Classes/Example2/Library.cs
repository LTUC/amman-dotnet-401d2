using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample.Classes
{
    class Library
    {
        public List<string> AvailableBooks { get; set; }

        public Library(List<string> books) => AvailableBooks = books;

        public void DisplayAvailableBooks()
        {
            Console.WriteLine();
            Console.WriteLine("Available Books");

            foreach (string book in AvailableBooks)
            {
                Console.WriteLine(book);
            }
        }

        public void LendBook(string requestBook)
        {
            if (AvailableBooks.Contains(requestBook))
            {
                Console.WriteLine("You have borrowed the book");
                AvailableBooks.Remove(requestBook);
            }
            else
            {
                Console.WriteLine("Sorry, the book is not available");
            }
        }

        public void AddBook(string returnedBook)
        {
            AvailableBooks.Add(returnedBook);
            Console.Write($"Thank you for returning the book {returnedBook}");
        }


    }
}
