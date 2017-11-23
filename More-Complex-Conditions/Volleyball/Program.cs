using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearLeapOrNormal = Console.ReadLine();
            var holidaysOnWorkDays = double.Parse(Console.ReadLine());
            var weekendsHome = double.Parse(Console.ReadLine());
            
            var weekendsSofia = 48 - weekendsHome;
            var sofiaWeekendGames = 3 * (weekendsSofia / 4);
            var sofiaHolidayGames = 2 * (holidaysOnWorkDays / 3);
            var sofiaGames = sofiaWeekendGames + sofiaHolidayGames;

            var normalYearGames = sofiaGames + weekendsHome;
            var leapYearGames = normalYearGames * 0.15 + normalYearGames;


            if (yearLeapOrNormal == "normal")
            {
                Console.WriteLine(Math.Truncate(normalYearGames));
            }
            else if (yearLeapOrNormal == "leap")
            {
                Console.WriteLine(Math.Truncate(leapYearGames));
            }
                        
        }
    }
}
