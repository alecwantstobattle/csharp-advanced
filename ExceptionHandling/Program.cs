using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //var calculator = new Calculator();
            //var result = calculator.Divide(5, 0);

            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide by 0.");
            //}
            //catch (ArithmeticException ex)
            //{

            //}
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred");
            }

            //var streamReader = new StreamReader(@"c:\file.zip");
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\file.zip");
                var content = streamReader.ReadToEnd();
                throw new Exception("Oops");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occurred");
            }
            finally
            {
                // Garbage collection
                if(streamReader != null)
                    streamReader.Dispose();
            }


            // Using statement instead of creating initial var and disposing it
            try
            {
                using (var streamReaderInUsing = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReaderInUsing.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occurred");
            }

            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
 