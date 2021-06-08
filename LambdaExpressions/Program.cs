using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            //number => number * number;

            // () => ...
            // x => ...
            // (x,y,z) => ...

            Func<int, int> square = number => number * number; // args, return type

            //Console.WriteLine(Square(5));
            Console.WriteLine(square(5));

            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);

            Console.WriteLine(result);

            var books = new BookRepository().GetBooks();
            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars); // predicate = delegate that points to a method and returns a boolean if a conditions is satisfied

            var cheapBooks = books.FindAll(book => book.Price < 10);

            foreach(var book in cheapBooks)
                Console.WriteLine(book.Title);
        }

        //static bool IsCheaperThan10Dollars(Book book)
        //{
        //    return book.Price < 10;
        //}

        //static int Square(int number)
        //{
        //    return number * number;
        //}
    }
}
