using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Library
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"{book.Title} has been added to the library");
        }

        public void DisplayTheBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }

        public void SearchByTitle(string title)
        {
            Console.WriteLine($"Search the books by Title: {title}");
            foreach (var book in books)
            {
                if (book.Title.ToLower().Contains(title.ToLower()))
                {
                    book.DisplayInfo();
                    Console.WriteLine();
                }
            }
        }

        public void SearchByAuthor(string author)
        {
            Console.WriteLine($"Search the books by Author: {author}");
            foreach (var book in books)
            {
                if (book.Author.ToLower().Contains(author.ToLower()))
                {
                    book.DisplayInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
