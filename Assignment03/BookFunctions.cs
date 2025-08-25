using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
   public delegate string BookDelegate(Book book);
    public static class BookFunctions
    {
        public static BookDelegate GetTitle = delegate (Book book) { return book.Title; };

        public static string GetAuthors(Book b) => string.Join(", ", b.Author);

        public static decimal GetPrice(Book book) { return book.Price; }

        public static BookDelegate GetISBN = delegate (Book b)
        {
            return b.ISBN;
        };

        public static Func<Book, string> GetPublicationDate = b => b.PublicationDate.ToShortDateString();

    }
}
