using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double wiskeyLiters = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice / 2.00;
            double winePrice = rakiaPrice - rakiaPrice * 0.40;
            double beerPrice = rakiaPrice - rakiaPrice * 0.80;

            double bill = wiskeyPrice * wiskeyLiters + beerPrice * beerLiters + winePrice * wineLiters + rakiaPrice * rakiaLiters;
            Console.WriteLine($"{bill:f2}");


        }
    }
}
