using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3ComplexConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            decimal monthsCount = decimal.Parse(Console.ReadLine());

            decimal monthBill = 0m;

            if (years == "one")
            {
                if (type == "Small")
                {
                    monthBill = 9.98m;
                }
                else if (type == "Middle")
                {
                    monthBill = 18.99m;
                }
                else if (type == "Large")
                {
                    monthBill = 25.98m;
                }
                else if (type == "ExtraLarge")
                {
                    monthBill = 35.99m;
                }
            }
            else if (years == "two")
            {
                if (type == "Small")
                {
                    monthBill = 8.58m;
                }
                else if (type == "Middle")
                {
                    monthBill = 17.09m;
                }
                else if (type == "Large")
                {
                    monthBill = 23.59m;
                }
                else if (type == "ExtraLarge")
                {
                    monthBill = 31.79m;
                }
            }

            if (internet == "yes")
            {
                if (monthBill <= 10)
                {
                    monthBill += 5.50m;
                }
                else if (monthBill <= 30m)
                {
                    monthBill += 4.35m;
                }
                else if (monthBill > 30m)
                {
                    monthBill += 3.85m;
                }
            }

            decimal bill = monthBill * monthsCount;

            if (years == "two")
            {
                bill -= (bill * 0.0375m);
            }
            
            Console.WriteLine($"{bill:f2} lv.");
        }
    }
}
