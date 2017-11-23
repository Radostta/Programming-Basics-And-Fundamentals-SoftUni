using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            double peopleCount = double.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine();

            string hall = "Small Hall";
            double price = 0;

            if (peopleCount <= 50)
            {
                price = 2500;
            }
            else if (peopleCount <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (peopleCount <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (servicePackage == "Normal")
            {
                price += 500;
                price -= price * 0.05;
            }
            else if (servicePackage == "Gold")
            {
                price += 750;
                price -= price * 0.10;
            }
            else if (servicePackage == "Platinum")
            {
                price += 1000;
                price -= price * 0.15;
            }

            double pricePerPerson = price / peopleCount;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
