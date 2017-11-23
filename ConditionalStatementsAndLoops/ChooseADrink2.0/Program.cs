using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double bill = 0;

            if (profession == "Athlete")
            {
                bill = 0.70 * quantity;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                bill = 1.00 * quantity;
            }
            else if (profession == "SoftUni Student")
            {
                bill = 1.70 * quantity;
            }
            else
            {
                bill = 1.20 * quantity;
            }

            Console.WriteLine($"The {profession} has to pay {bill:f2}.");
        }
    }
}
