using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetableKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());

            double incomeBGN = vegetablePrice * vegetableKg + fruitPrice * fruitKg;
            double incomeEUR = incomeBGN / 1.94;

            Console.WriteLine(incomeEUR);
        }
    }
}
