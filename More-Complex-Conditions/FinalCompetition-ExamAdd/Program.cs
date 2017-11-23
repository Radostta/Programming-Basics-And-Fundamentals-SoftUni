using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCompetition_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double dancersCount = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double cash = 0.00;

            if (place == "Bulgaria")
            {
                if (season == "summer")
                {
                    cash = points * dancersCount;
                    cash -= cash * 0.05;
                }
                else if (season == "winter")
                {
                    cash = points * dancersCount;
                    cash -= cash * 0.08;
                }
            }
            else if (place == "Abroad")
            {
                if (season == "summer")
                {
                    cash = points * dancersCount;
                    cash += cash * 0.50;
                    cash -= cash * 0.10;
                }
                else if (season == "winter")
                {
                    cash = points * dancersCount;
                    cash += cash * 0.50;
                    cash -= cash * 0.15;
                }
            }

            double charity = cash * 0.75;
            double cashPerDancer = (cash - charity) / dancersCount;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {cashPerDancer:f2}");



        }
    }
}
