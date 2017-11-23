using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int leisureDays = int.Parse(Console.ReadLine());
            int normalPlayPerYear = 30000;
            int workDays = 365 - leisureDays;

            int play = leisureDays * 127 + workDays * 63;
            int difference = Math.Abs(normalPlayPerYear - play);
            int hours = difference / 60;
            int minutes = difference % 60;

            while (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }

            if (play > normalPlayPerYear)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
