using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball_Book
{
    class Program
    {
        static void Main(string[] args)
        {

            //var year = Console.ReadLine();
            //var holidays = double.Parse(Console.ReadLine());
            //var weekendsHome = double.Parse(Console.ReadLine());

            //var sofiaWeekends = 48 - weekendsHome;
            //double playSofia = (3 * sofiaWeekends / 4) + (2 * holidays / 3);
            //double playTotal = playSofia + weekendsHome;

            //if (year == "leap")
            //{
            //    Console.WriteLine(Math.Truncate(playTotal * 0.15 + playTotal));
            //}
            //else if (year == "normal")
            //{
            //    Console.WriteLine(Math.Truncate(playTotal));
            //}

            var yearType = Console.ReadLine().ToLower();
            var weekHolidays = double.Parse(Console.ReadLine());
            var travelWeekendsPlay = double.Parse(Console.ReadLine());
            var sofiaPlay = ((48 - travelWeekendsPlay) / 4 * 3) + (weekHolidays / 3 * 2);
            var totalPlay = travelWeekendsPlay + sofiaPlay;

            switch (yearType)
            {
                case "leap":
                    Console.WriteLine(Math.Truncate(totalPlay * 0.15 + totalPlay)); break;
                case "normal":
                    Console.WriteLine(Math.Truncate(totalPlay)); break;
            }



        }
    }
}
