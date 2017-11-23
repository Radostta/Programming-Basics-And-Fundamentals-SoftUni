using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSquares = double.Parse(Console.ReadLine());
            double grapesPerSquare = double.Parse(Console.ReadLine());
            double litersWineNeeded = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double grapes = totalSquares * grapesPerSquare;
            grapes *= 0.4;
            double wine = grapes / 2.5;

            double difference = Math.Abs(wine - litersWineNeeded);
            double winePerWorker = difference / workers;

            if (wine < litersWineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(difference)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(difference)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");
            }

        }
    }
}
