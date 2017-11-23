using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var destination = string.Empty;
            var facility = string.Empty;
            var moneySpent = 0.00m;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    destination = "Bulgaria";
                    facility = "Camp";
                    moneySpent = budget * 0.30m;

                }
                else if (season == "winter")
                {
                    destination = "Bulgaria";
                    facility = "Hotel";
                    moneySpent = budget * 0.70m;
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    destination = "Balkans";
                    facility = "Camp";
                    moneySpent = budget * 0.40m;
                }
                else if (season == "winter")
                {
                    destination = "Balkans";
                    facility = "Hotel";
                    moneySpent = budget * 0.80m;
                }
            }
            else
            {
                destination = "Europe";
                facility = "Hotel";
                moneySpent = budget * 0.90m;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{facility} - {moneySpent:f2}");
        }
    }
}
