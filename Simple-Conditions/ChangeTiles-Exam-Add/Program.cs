using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double workerCharge = double.Parse(Console.ReadLine());

            double floorArea = floorWidth * floorLength;
            double tileArea = triangleSide * triangleHeight / 2.00;
            double tilesNeeded = Math.Ceiling(floorArea / tileArea);
            double totalTiles = tilesNeeded + 5;
            double totalCost = totalTiles * pricePerTile + workerCharge;

            if (totalCost <= money)
            {
                Console.WriteLine($"{(money - totalCost):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(totalCost - money):f2} lv more.");
            }
        }
    }
}
