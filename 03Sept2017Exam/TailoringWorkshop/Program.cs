using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tablesCount = double.Parse(Console.ReadLine());
            double tablesLength = double.Parse(Console.ReadLine());
            double tablesWidth = double.Parse(Console.ReadLine());

            double clothArea = tablesCount * ((tablesLength + 0.6) * (tablesWidth + 0.6));
            double coverArea = tablesCount * ((tablesLength / 2) * (tablesLength / 2));

            double clothCostDollars = clothArea * 7;
            double coverCostDollars = coverArea * 9;

            double clothCostBGN = clothCostDollars * 1.85;
            double coverCostBGN = coverCostDollars* 1.85;

            Console.WriteLine($"{(clothCostDollars + coverCostDollars):f2} USD");
            Console.WriteLine($"{(clothCostBGN + coverCostBGN):f2} BGN");

        }
    }
}
