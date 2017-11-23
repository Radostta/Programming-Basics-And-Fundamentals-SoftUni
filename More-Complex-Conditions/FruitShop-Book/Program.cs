using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //Error:
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var price = 0.0;

            var dayInRange = day == "monday" || day == "tuesday" || day == "wednsday" || day == "thursday" || day == "friday" || day == "saturday" || day == "sunday";
            var fruitInRange = fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes";

            if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana") price = 2.70;
                else if (fruit == "apple") price = 1.25;
                else if (fruit == "orange") price = 0.90;
                else if (fruit == "grapefruit") price = 1.60;
                else if (fruit == "kiwi") price = 3.00;
                else if (fruit == "pineapple") price = 5.60;
                else if (fruit == "grapes") price = 4.20;
            }
            else if ((day == "monday" || day == "thuesday" || day == "wednsday" || day == "thursday" || day == "friday"))
            {
                if (fruit == "banana") price = 2.50;
                else if (fruit == "apple") price = 1.20;
                else if (fruit == "orange") price = 0.85;
                else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "kiwi") price = 2.70;
                else if (fruit == "pineapple") price = 5.50;
                else if (fruit == "grapes") price = 3.85;
            }

            if (dayInRange || fruitInRange)
            {
                Console.WriteLine($"{(price * quantity):f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            
            

        }
    }
}
