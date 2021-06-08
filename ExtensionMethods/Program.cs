using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "The list is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
            var max = numbers.Max();

            Console.WriteLine(shortenedPost);
            Console.WriteLine(max);
        }
    }

    //public class RichString : String // sealed
    //{

    //}
}
