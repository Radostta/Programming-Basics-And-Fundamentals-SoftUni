using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = string.Empty;
            string accomodation = string.Empty;
            double price = 0.00;

            if (budget >= 10 && budget <= 1000)
            {
                accomodation = "Camp";
                if (season == "Summer")
                {
                    location ="Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                accomodation = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else if (budget > 3000 && budget <= 10000)
            {
                accomodation = "Hotel";
                price = budget * 0.90;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                }
            }

            Console.WriteLine($"{location} - {accomodation} - {price:f2}");
        }
    }
}
