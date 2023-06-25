using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Library
{
    public class NonFictionBook : Book
    {
        public NonFictionBook(string title, string author, int publicationYear)
            : base(title, author, publicationYear)
        {
            
        }
    }
}
