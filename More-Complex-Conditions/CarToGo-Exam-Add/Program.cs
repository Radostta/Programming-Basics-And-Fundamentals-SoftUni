﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGo_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carClass = string.Empty;
            string carType = string.Empty;
            double carPrice = 0.00;

            if (budget <= 100)
            {
                carClass = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    carPrice = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    carPrice = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    carPrice = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    carPrice = budget * 0.80;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                carPrice = budget * 0.90;
            }

            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {carPrice:f2}");
        }
    }
}
