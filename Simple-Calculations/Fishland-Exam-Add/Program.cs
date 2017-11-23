using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            //var mackerelPrice = double.Parse(Console.ReadLine());
            //var spratPrice = double.Parse(Console.ReadLine());
            //var palamudKg = double.Parse(Console.ReadLine());
            //var horsemackerelKg = double.Parse(Console.ReadLine());
            //var shellfishKg = double.Parse(Console.ReadLine());

            //var shellfishPrice = 7.50;
            //var palamudPrice = 0.60 * mackerelPrice + mackerelPrice;
            //var horsemackerelPrice = 0.80 * spratPrice + spratPrice;



            double mackerelPricePerKg = double.Parse(Console.ReadLine());
            double spratPricePerKg = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double horseMackerelKg = double.Parse(Console.ReadLine());
            double shellfishKg = double.Parse(Console.ReadLine());

            double palamudPricePerKg = mackerelPricePerKg * 0.60 + mackerelPricePerKg;
            double horseMackerelPricePerKg = spratPricePerKg * 0.80 + spratPricePerKg;
            double shellfishPricePerKg = 7.50;

            double bill = palamudKg * palamudPricePerKg + horseMackerelKg * horseMackerelPricePerKg + shellfishKg * shellfishPricePerKg;

            Console.WriteLine($"{bill:f2}");

        }
    }
}
