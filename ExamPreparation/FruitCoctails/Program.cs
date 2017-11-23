using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCoctails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            double coctailsCount = double.Parse(Console.ReadLine());
            double coctailPrice = 0;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    coctailPrice = 56 * 2;
                }
                else
                {
                    coctailPrice = 28.70 * 5;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    coctailPrice = 36.66 * 2;
                }
                else
                {
                    coctailPrice = 19.60 * 5;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    coctailPrice = 42.10 * 2;
                }
                else
                {
                    coctailPrice = 24.80 * 5;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    coctailPrice = 20 * 2;
                }
                else
                {
                    coctailPrice = 15.20 * 5;
                }
            }

            double bill = coctailPrice * coctailsCount;

            if (bill > 1000) bill -= bill * 0.50;
            else if (bill >= 400) bill -= bill * 0.15;

            Console.WriteLine($"{bill:f2} lv.");
        }
    }
}
