using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            // obj.GetHashCode() // without reflection

            var methodInfo = obj.GetType().GetMethod("GetHashCode"); // if you use reflection
            methodInfo.Invoke(null, null);

            dynamic excelObject = "mosh";
            excelObject.Optimize();

            dynamic name = "Mosh";
            //name = 10;
            name++; // throws error 

            dynamic a = 10;
            dynamic b = 10;
            var c = a + b; // c will be dynamic[int]

            int i = 5;
            dynamic d = i; // d is dynamic with runtime type int
            long l = d; // doesn't need explicit casting

        }
    }
}
 