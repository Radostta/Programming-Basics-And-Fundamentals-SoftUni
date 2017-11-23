using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoroTheFootballPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNormal = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double hometownWeekends = double.Parse(Console.ReadLine());
            double normalWeekends = 52 - hometownWeekends;

            double playHolidays = holidays / 2;
            double playHometownWeekends = hometownWeekends;
            double playNormalWeekends = (normalWeekends * 1 / 3) * 2;

            double playTotal = playHolidays + playHometownWeekends + playNormalWeekends;
            if (leapOrNormal == "t") playTotal += 3.00;

            Console.WriteLine(Math.Floor(playTotal));
            


        }
    }
}
