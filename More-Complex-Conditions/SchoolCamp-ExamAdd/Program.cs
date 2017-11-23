using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            double studentsCount = double.Parse(Console.ReadLine());
            double nightsCount = double.Parse(Console.ReadLine());

            string sport = string.Empty;
            double totalPrice = 0.00;

            if (season == "Winter")
            {
                if (group == "girls")
                {
                    sport = "Gymnastics";
                    totalPrice = nightsCount * 9.60;
                }
                else if (group == "boys")
                {
                    sport = "Judo";
                    totalPrice = nightsCount * 9.60;

                }
                else if (group == "mixed")
                {
                    sport = "Ski";
                    totalPrice = nightsCount * 10.00;
                }
            }
            else if (season == "Spring")
            {
                if (group == "girls")
                {
                    sport = "Athletics";
                    totalPrice = nightsCount * 7.20;
                }
                else if (group == "boys")
                {
                    sport = "Tennis";
                    totalPrice = nightsCount * 7.20;

                }
                else if (group == "mixed")
                {
                    sport = "Cycling";
                    totalPrice = nightsCount * 9.50;
                }
            }
            else if (season == "Summer")
            {
                if (group == "girls")
                {
                    sport = "Volleyball";
                    totalPrice = nightsCount * 15.00;
                }
                else if (group == "boys")
                {
                    sport = "Football";
                    totalPrice = nightsCount * 15.00;

                }
                else if (group == "mixed")
                {
                    sport = "Swimming";
                    totalPrice = nightsCount * 20.00;
                }
            }

            totalPrice *= studentsCount;

            if (studentsCount >= 50)
            {
                totalPrice -= totalPrice * 0.50;
            }
            else if (studentsCount >= 20)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (studentsCount >= 10)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"{sport} {totalPrice:f2} lv.");
        }
    }
}
