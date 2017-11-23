using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshopExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int tablesCount = int.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double tableclothArea = (tableLength + 2 * 0.30) * (tableWidth + 2 * 0.30);
            double tableclothAreaTotal = tableclothArea * tablesCount;

            double squareArea = (tableLength / 2) * (tableLength / 2);
            double squareAreaTotal = squareArea * tablesCount;

            double priceInDollars = tableclothAreaTotal * 7 + squareAreaTotal * 9;
            double priceInLeva = priceInDollars * 1.85;

            Console.WriteLine($"{priceInDollars:f2} USD");
            Console.WriteLine($"{priceInLeva:f2} BGN");

        }
    }
}
