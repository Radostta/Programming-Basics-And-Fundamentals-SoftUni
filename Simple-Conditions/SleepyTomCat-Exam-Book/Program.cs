using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat_Exam_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int leisureDays = int.Parse(Console.ReadLine());
            int workDays = 365 - leisureDays;

            int leisurePlay = leisureDays * 127;
            int workPlay = workDays * 63;
            int totalPlay = leisurePlay + workPlay;

            if (totalPlay > 30000)
            {
                int surplus = totalPlay - 30000;
                int sHours = surplus / 60;
                int sMinutes = surplus % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{sHours} hours and {sMinutes} minutes more for play");
            }

            else if (totalPlay < 30000)
            {
                int deficit = 30000 - totalPlay;
                int dHours = deficit / 60;
                int dMinutes = deficit % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{dHours} hours and {dMinutes} minutes less for play");
            }
        }
    }
}
