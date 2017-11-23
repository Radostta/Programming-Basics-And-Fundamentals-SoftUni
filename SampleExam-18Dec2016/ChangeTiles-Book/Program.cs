using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double workerCharge = double.Parse(Console.ReadLine());

            double bathroomArea = width * length;
            double tileArea = side * height / 2;
            double numberTiles = Math.Ceiling(bathroomArea / tileArea) + 5;
            double cost = numberTiles * pricePerTile + workerCharge;
            double diff = Math.Abs(money - cost);

            if (money < cost)
            {
                Console.WriteLine($"You'll need {diff:f2} lv more.");
            }
            else
            {
                Console.WriteLine($"{diff:f2} lv left.");
            }
            


        }
    }
}
