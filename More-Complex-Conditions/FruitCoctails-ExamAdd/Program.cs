using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCoctails_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string bucket = Console.ReadLine();
            double bucketCount = double.Parse(Console.ReadLine());
            double bucketPrice = 0.00;

            if (bucket == "small")
            {
                if (fruit == "Watermelon")
                {
                    bucketPrice = 2.00 * 56.00;
                }
                else if (fruit == "Mango")
                {
                    bucketPrice = 2.00 * 36.66;
                }
                else if (fruit == "Pineapple")
                {
                    bucketPrice = 2.00 * 42.10;
                }
                else if (fruit == "Raspberry")
                {
                    bucketPrice = 2.00 * 20.00;
                }
            }
            else if (bucket == "big")
            {
                if (fruit == "Watermelon")
                {
                    bucketPrice = 5.00 * 28.70;
                }
                else if (fruit == "Mango")
                {
                    bucketPrice = 5.00 * 19.60;
                }
                else if (fruit == "Pineapple")
                {
                    bucketPrice = 5.00 * 24.80;
                }
                else if (fruit == "Raspberry")
                {
                    bucketPrice = 5.00 * 15.20;
                }
            }

            double bill = bucketPrice * bucketCount;
            
            
            if (bill > 1000)
            {
                bill -= bill * 0.50;
            }
            else if (bill >= 400)
            {
                bill -= bill * 0.15;
            }

            Console.WriteLine($"{bill:f2} lv.");
        }
    }
}
