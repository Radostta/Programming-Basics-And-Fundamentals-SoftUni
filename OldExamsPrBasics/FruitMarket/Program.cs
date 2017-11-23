using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            decimal totalBill = 0.00m;

            for (int productCount = 0; productCount < 3; productCount++)
            {
                decimal productQuantity = decimal.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                decimal productCost = 0.00m;

                if (product == "banana") productCost += productQuantity * 1.80m;
                else if (product == "cucumber") productCost += productQuantity * 2.75m;
                else if (product == "tomato") productCost += productQuantity * 3.20m;
                else if (product == "orange") productCost += productQuantity * 1.60m;
                else if (product == "apple") productCost += productQuantity * 0.86m;

                switch (day)
                {
                    case "Tuesday":
                        if (product == "banana" || product == "orange" || product == "apple") productCost -= productCost * 0.2m;
                        break;
                    case "Wednesday":
                        if (product == "cucumber" || product == "tomato") productCost -= productCost * 0.1m;
                        break;
                    case "Thursday":
                        if (product == "banana") productCost -= productCost * 0.3m;
                        break;
                    case "Friday":
                        if (product == "banana" || product == "orange" || product == "apple" || product == "cucumber" || product == "tomato")
                            productCost -= productCost * 0.1m;
                        break;
                    case "Sunday":
                        if (product == "banana" || product == "orange" || product == "apple" || product == "cucumber" || product == "tomato")
                            productCost -= productCost * 0.05m;
                        break;                    
                }
                totalBill += productCost;
            }

            Console.WriteLine($"{totalBill:f2}");
        }
    }
}
