using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshopAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            double tablesCount = double.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tablesWidth = double.Parse(Console.ReadLine());

            double clothsArea = (tableLength + 0.60) * (tablesWidth + 0.60) * tablesCount;
            double squaresArea = (tableLength / 2) * (tableLength / 2) * tablesCount;

            double priceInEuro = clothsArea * 7 + squaresArea * 9;
            double priceInLeva = priceInEuro * 1.85;

            Console.WriteLine($"{priceInEuro:f2} USD");
            Console.WriteLine($"{priceInLeva:f2} BGN");


        }
    }
}
