using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var day = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            bool isWeekend = day == "Saturday" || day == "Sunday";
            bool isWeekday = day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday";

            var productPrice = 0.0;

            if (isWeekend)
            {
                if (product == "banana")
                {
                    productPrice = 2.70;
                }
                else if (product == "apple")
                {
                    productPrice = 1.25;
                }
                else if (product == "orange")
                {
                    productPrice = 0.90;
                }
                else if (product == "grapefruit")
                {
                    productPrice = 1.60;
                }
                else if (product == "kiwi")
                {
                    productPrice = 3.00;
                }
                else if (product == "pineapple")
                {
                    productPrice = 5.60;
                }
                else if (product == "grapes")
                {
                    productPrice = 4.20;
                }
            }
            else if (isWeekday)
            {
                if (product == "banana")
                {
                    productPrice = 2.50;
                }
                else if (product == "apple")
                {
                    productPrice = 1.20;
                }
                else if (product == "orange")
                {
                    productPrice = 0.85;
                }
                else if (product == "grapefruit")
                {
                    productPrice = 1.45;
                }
                else if (product == "kiwi")
                {
                    productPrice = 2.70;
                }
                else if (product == "pineapple")
                {
                    productPrice = 5.50;
                }
                else if (product == "grapes")
                {
                    productPrice = 3.85;
                }
            }

            if ((isWeekday || isWeekend) && (product == "banana" || product == "apple" || product == "orange" || product == "grapefruit" || product == "kiwi" || product == "pineapple" || product == "grapes"))
            {
                Console.WriteLine($"{productPrice * quantity:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
