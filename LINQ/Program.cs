using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var cheapBooks = new List<Book>();

            //foreach (var book in books)
            //{
            //    if(book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //var cheapBooks = books.Where(b => b.Price < 10);

            // LINQ Query Operators
            var cheaperBooks = from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            // LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title); // Chaining

            foreach (var b in cheapBooks)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(b);
            }

            // LINQ Extension Methods
            //var book = books.Single(b => b.Title == "ASP.NET MVC");
            var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");

            //var firstBook = books.First(b => b.Title == "C# Advanced Topics");
            var firstBook = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            var lastBook = books.LastOrDefault(b => b.Title == "C# Advanced Topics");

            Console.WriteLine(firstBook.Title + " " + firstBook.Price);

            var pagedBooks = books.Skip(2).Take(3);

            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);   
            }

            var count = books.Count();
            Console.WriteLine(count);

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);

            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);

            var totalPrice = books.Sum(b => b.Price);
            Console.WriteLine(totalPrice);
        }
    }
}
