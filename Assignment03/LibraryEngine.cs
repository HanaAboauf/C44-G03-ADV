using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public class LibraryEngine
    {

        public static void ProcessBooks(List<Book> bList, BookDelegate fPtr)
        {
            foreach (Book book in bList)
            {
                Console.WriteLine(fPtr(book));
            }
        }
        public static void ProcessBooks(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (var book in books)
            {
                Console.WriteLine(fPtr(book));
            }
        }

    }
}
