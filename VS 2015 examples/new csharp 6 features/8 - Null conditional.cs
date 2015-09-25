using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_csharp_6_features
{
    public class NullConditional
    {
        public void Main()
        {
            Book nullBook = null;
            Book bookWithNulls = new Book();
            Book goodBook = GetGoodBook();

            "".Dump("Old way");
            OldWay(nullBook).Dump();
            OldWay(bookWithNulls).Dump();
            OldWay(goodBook).Dump();
            OldWayFirstReview(goodBook).Dump();


            "".Dump("New way");
            NewWay(nullBook).Dump();
            NewWay(bookWithNulls).Dump();
            NewWay(goodBook).Dump();
            NewWayFirstReview(goodBook).Dump();
        }

        public string OldWay(Book book)
        {
            if (book == null) return "Book is null.";
            if (book.Details == null) return "Book has no details.";

            return book.Details.Author;
        }

        public string AlternativeOldWay(Book book)
        {
            var result = (book == null)
                            ? "Book is null."
                            : (book.Details == null)
                                ? "Book has no details."
                                : book.Details.Author;

            return result;
        }

        public string NewWay(Book book)
        {
            return book?.Details?.Author ?? "Book is null or has no details.";
        }

        public string OldWayFirstReview(Book book)
        {
            if (book == null) return "Book is null.";
            if (book.Reviews == null)
                return "Book has no reviews.";

            return book.Reviews[0].Text;
        }

        public string NewWayFirstReview(Book book)
        {
            return book?.Reviews?[0].Text ?? "Book is null or has no reviews";
        }

        public class Book
        {
            public BookDetails Details;
            public List<BookReview> Reviews;
        }

        public class BookDetails
        {
            public string Author = "Mr. Byte";
            public int Pages = 512;
        }

        public class BookReview
        {
            public string Text = "A very boring book.";
            public int Rating = 1;
        }

        public static Book GetGoodBook()
        {
            return new Book
            {
                Details = new BookDetails(),
                Reviews = new List<BookReview> { new BookReview() }
            };
        }
    }
}
