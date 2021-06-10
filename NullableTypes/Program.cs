using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> date = null;
            //DateTime? date = null;

            //Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value);

            //DateTime? date = new DateTime(2014, 1, 1);
            //DateTime date2 = date.GetValueOrDefault();
            //DateTime? date3 = date2;

            DateTime? date = null;
            //DateTime date2;
            DateTime date2 = date ?? DateTime.Today; // Null Coalesce

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today; // Tertiary Operator

            //if (date != null)
            //    date2 = date.GetValueOrDefault();
            //else
            //{
            //    date2 = DateTime.Today;
            //}

            Console.WriteLine(date2);
        }
    }
}
