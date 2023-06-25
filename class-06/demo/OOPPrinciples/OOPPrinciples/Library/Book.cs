using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Library
{
    public abstract class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }
        public int PublicastionYear { get; set; }
        public bool IsAvilable { get; set; }

        public Book(string title, string author, int publicationYear)
        {
            
            Title = title;
            Author = author;
            PublicastionYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title:{Title}");
            Console.WriteLine($"Author:{Author}");
            Console.WriteLine($"Publicastion Year:{PublicastionYear}");
            Console.WriteLine($"Availability:{IsAvilable}");

        }

        public virtual void CheckOut()
        {
            if ( IsAvilable)
            {
                IsAvilable = false;
                Console.WriteLine($"{Title} has been checked out");

            }
            else
            {
                Console.WriteLine($"{Title} is already checked out");
            }
        }

        public virtual void Return()
        {
            if(!IsAvilable) 
            {
                IsAvilable = true;
                Console.WriteLine($"{Title} has been returned");
            }
            else
            {
                Console.WriteLine($"{Title} is already available");
            }
        }
    }
}
