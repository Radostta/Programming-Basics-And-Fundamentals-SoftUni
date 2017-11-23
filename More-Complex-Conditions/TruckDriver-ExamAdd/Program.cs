using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double kmPerSeason = kmPerMonth * 4;
            double salary = 0.00;

            if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = kmPerSeason * 0.75;
                }
                else if (season == "Summer")
                {
                    salary = kmPerSeason * 0.90;
                }
                else if (season == "Winter")
                {
                    salary = kmPerSeason * 1.05;
                }
            }
            else if (kmPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = kmPerSeason * 0.95;
                }
                else if (season == "Summer")
                {
                    salary = kmPerSeason * 1.10;
                }
                else if (season == "Winter")
                {
                    salary = kmPerSeason * 1.25;
                }
            }
            else if (kmPerMonth <= 20000)
            {
                salary = kmPerSeason * 1.45;
            }

            salary -= salary * 0.10;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
