using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //    // Using System.Globalization;
            //    //instead of new DateTime, it is DateTime.ParseExact("inputAsString", "formatAsString", Provider or null);
            //    //if we want for example French culture: instead of .InvariantCulture(no culture), it will be:
            //    //.CultureInfo.GetCultureInfo(FR-fr);

            //    string input = Console.ReadLine();

            //    DateTime myDate = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            //    Console.WriteLine(myDate.DayOfWeek);

            //By splitting the input:

            var input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            var day = input[0];
            var month = input[1];
            var year = input[2];

            DateTime myDate = new DateTime(year, month, day);
            Console.WriteLine(myDate);
            Console.WriteLine(myDate.DayOfWeek);

            ////creating our dateTime:
            //DateTime myDateTime = new DateTime(1994, 10, 28); //year, month, day
            //Console.WriteLine(myDateTime.DayOfWeek); - //after pressing . we can use different properties of the object
        }
    }
}
