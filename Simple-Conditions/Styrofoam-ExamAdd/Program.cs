using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            double windowsCount = double.Parse(Console.ReadLine());
            double sqMInPackage = double.Parse(Console.ReadLine());
            double packagePrice = double.Parse(Console.ReadLine());

            double area = (houseArea - windowsCount * 2.40) + (houseArea - windowsCount * 2.40) * 0.10;
            double packagesCount = Math.Ceiling(area / sqMInPackage);
            double cost = packagesCount * packagePrice;

            if (budget >= cost)
            {
                Console.WriteLine($"Spent: {cost:f2}");
                Console.WriteLine($"Left: {(budget - cost):f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {(cost - budget):f2}");
            }

        }
    }
}
