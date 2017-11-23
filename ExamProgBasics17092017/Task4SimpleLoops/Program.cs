using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4SimpleLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal allLiters = 0m;
            decimal currentDegree = 0m;
            decimal allDegrees = 0m;

            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                decimal rakiaQuantity = decimal.Parse(Console.ReadLine());
                decimal rakiaDegrees = decimal.Parse(Console.ReadLine());

                allLiters += rakiaQuantity;
                currentDegree = rakiaDegrees * rakiaQuantity;
                allDegrees += currentDegree;
            }

            decimal avrDegree = allDegrees / allLiters;


            Console.WriteLine($"Liter: {allLiters:f2}");
            Console.WriteLine($"Degrees: {avrDegree:f2}");

            if (avrDegree < 38m)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (avrDegree >= 38m && avrDegree <= 42m)
            {
                Console.WriteLine("Super!");
            }
            else if (avrDegree > 42m)
            {
                Console.WriteLine("Dilution with distilled water!");
            }


            //int days = int.Parse(Console.ReadLine());
            //double litersCount = 0.00;
            //double degreesCount = 0.00;

            //for (int currentDay = 0; currentDay < days; currentDay++)
            //{
            //    double liters = double.Parse(Console.ReadLine());
            //    double degrees = double.Parse(Console.ReadLine());

            //    litersCount += liters;
            //    degreesCount += liters * degrees;
            //}

            //double totalDegrees = degreesCount / litersCount;

            //Console.WriteLine($"Liter: {litersCount:f2}");
            //Console.WriteLine($"Degrees: {totalDegrees:f2}");

            //if (totalDegrees < 38) Console.WriteLine("Not good, you should baking!");
            //if (totalDegrees <= 42) Console.WriteLine("Super!");
            //if (totalDegrees > 42) Console.WriteLine("Dilution with distilled water!");


        }
    }
}
