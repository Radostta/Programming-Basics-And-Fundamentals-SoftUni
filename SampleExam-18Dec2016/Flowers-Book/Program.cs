using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double chrisCount = double.Parse(Console.ReadLine());
            double rosesCount = double.Parse(Console.ReadLine());
            double tulipsCount = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isHoliday = Console.ReadLine();
            double chrisCountCost = 0.00;
            double rosesCountCost = 0.00;
            double tulipsCountCost = 0.00;


            if (season == "Spring" || season == "Summer")
            {
                chrisCountCost = chrisCount * 2.00;
                rosesCountCost = rosesCount * 4.10;
                tulipsCountCost = tulipsCount * 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrisCountCost = chrisCount * 3.75;
                rosesCountCost = rosesCount * 4.50;
                tulipsCountCost = tulipsCount * 4.15;
            }

            if (isHoliday == "Y")
            {
                chrisCountCost += chrisCountCost * 0.15;
                rosesCountCost += rosesCountCost * 0.15;
                tulipsCountCost += tulipsCountCost * 0.15;
            }

            double total = chrisCountCost + rosesCountCost + tulipsCountCost;
            double allFlowers = chrisCount + rosesCount + tulipsCount;

            if (tulipsCount > 7 && season == "Spring") total -= total * 0.05;
            if (rosesCount >= 10 && season == "Winter") total -= total * 0.10;
            if (allFlowers > 20) total -= total * 0.20;

            Console.WriteLine($"{(total + 2):f2}");

        }
    }
}
