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
            var pricePerKgV = double.Parse(Console.ReadLine());
            var pricePerKgF = double.Parse(Console.ReadLine());
            var vegKg = double.Parse(Console.ReadLine());
            var fruitKg = double.Parse(Console.ReadLine());

            var income = fruitKg * pricePerKgF + vegKg * pricePerKgV;
            
            Console.WriteLine(income / 1.94);
        
        }
    }
}
