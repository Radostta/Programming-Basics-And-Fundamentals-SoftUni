using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accomodation = "";
            string destination = "";
            double price = 0;

            if (budget > 3000)
            {
                accomodation = "Hotel";
                price = budget * 0.90;
                if (season == "Summer")
                {
                    destination = "Alaska";
                }
                else
                {
                    destination = "Morocco";
                }
            }
            else if (budget > 1000)
            {
                accomodation = "Hut";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    price = budget * 0.80;
                }
                else
                {
                    destination = "Morocco";
                    price = budget * 0.60;
                }
            }
            else
            {
                accomodation = "Camp";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    price = budget * 0.65;
                }
                else
                {
                    destination = "Morocco";
                    price = budget * 0.45;
                }
            }

            Console.WriteLine($"{destination} - {accomodation} - {price:f2}");
        }
    }
}
