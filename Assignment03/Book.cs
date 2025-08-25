using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public class Book
    {
    
        #region Properties
        public string ISBN { get; set; }
        public string Title { get; set; }

        public string[] Author { get; set; }

        public DateTime PublicationDate { get; set; }

        public decimal Price { get; set; }
        #endregion

        #region Constructor
        public Book(string iSBN, string title, string[] author, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN ?? throw new ArgumentNullException(nameof(iSBN));
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Author = author ?? throw new ArgumentNullException(nameof(author));
            PublicationDate = publicationDate;
            Price = price;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Author(s): {string.Join(", ", Author)}, Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price:C}";
        }
        #endregion

    }
}
