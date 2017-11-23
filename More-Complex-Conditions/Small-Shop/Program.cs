using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (town.Equals("sofia"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(0.50 * quantity);
                }
                else if (product.Equals("water"))
                {
                    Console.WriteLine(0.80 * quantity);
                }                    
                else if (product.Equals("beer"))
                {
                    Console.WriteLine(1.20 * quantity);
                }
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(1.45 * quantity);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(1.60 * quantity);
                }
            }
            else if (town.Equals("plovdiv"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(0.40 * quantity);
                }
                else if (product.Equals("water"))
                {
                    Console.WriteLine(0.70 * quantity);
                }
                else if (product.Equals("beer"))
                {
                    Console.WriteLine(1.15 * quantity);
                }
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(1.30 * quantity);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(1.50 * quantity);
                }
            }
            else if (town.Equals("varna"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(0.45 * quantity);
                }

                else if (product.Equals("water"))
                {
                    Console.WriteLine(0.70 * quantity);
                }

                else if (product.Equals("beer"))
                {
                    Console.WriteLine(1.10 * quantity);
                }
                
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(1.35 * quantity);
                }

                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(1.55 * quantity);
                }
            }

        }
    }
}
