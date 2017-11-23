using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double cupsNeeded = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workDays = double.Parse(Console.ReadLine());
            double workHours = workDays * 8.00 * workers;
            double cupsDone = Math.Floor(workHours / 5.00);
            double cupsDiff = Math.Abs(cupsDone - cupsNeeded);
            double money = cupsDiff * 4.20;

            if (cupsDone >= cupsNeeded)
            {
                Console.WriteLine($"{money:f2} extra money");
            }
            else
            {
                Console.WriteLine($"Losses: {money:f2}");
            }
        }
    }
}
