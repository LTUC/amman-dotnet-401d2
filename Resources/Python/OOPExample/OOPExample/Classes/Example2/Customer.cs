using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample.Classes
{
    class Customer
    {
        public string RequestBook()
        {
            Console.WriteLine("Enter the name of the book you would like to borrow");
            string requestBook = Console.ReadLine();
            return requestBook;
        }
    }
}
