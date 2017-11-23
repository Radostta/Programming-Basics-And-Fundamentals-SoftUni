using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string accomodation = "Hotel";
            double price = 0.00;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    price = budget * 0.3;
                }
                else
                {
                    price = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    price = budget * 0.4;
                }
                else
                {
                    price = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                price = budget * 0.9;               
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {price:f2}");

        }
    }
}
