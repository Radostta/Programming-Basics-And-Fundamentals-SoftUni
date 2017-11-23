using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double bakers = double.Parse(Console.ReadLine());
            double cakesPerDay = double.Parse(Console.ReadLine());
            double wafersPerDay = double.Parse(Console.ReadLine());
            double pancakesPerDay = double.Parse(Console.ReadLine());

            double dayIncomePerBaker = (cakesPerDay * 45) + (wafersPerDay * 5.80) + (pancakesPerDay * 3.20);
            double totalIncome = dayIncomePerBaker * days * bakers;
            double expenses = totalIncome / 8 * 1;
            totalIncome -= expenses;

            Console.WriteLine($"{totalIncome:f2}");
        }
    }
}
