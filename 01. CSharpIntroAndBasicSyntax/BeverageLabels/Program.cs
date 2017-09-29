using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyPer100Ml = double.Parse(Console.ReadLine());
            double sugarPer100Ml = double.Parse(Console.ReadLine());

            double energyContent = volume * (energyPer100Ml / 100.00);
            double sugarContent = volume * (sugarPer100Ml / 100.00);

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");


        }
    }
}
