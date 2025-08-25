namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>
        {
            new Book("12345", "C# in Depth", new string[] {"Jon Skeet"}, new DateTime(2019, 3, 23), 45.5m),
            new Book("67890", "CLR via C#", new string[] {"Jeffrey Richter"}, new DateTime(2012, 2, 14), 55.0m),
            new Book("11223", "Pro ASP.NET Core", new string[] {"Adam Freeman"}, new DateTime(2020, 8, 5), 60.0m)
        };

            LibraryEngine.ProcessBooks(library, BookFunctions.GetTitle);


            LibraryEngine.ProcessBooks(library, BookFunctions.GetISBN);

            LibraryEngine.ProcessBooks(library, BookFunctions.GetPublicationDate);
        }
    }
}
