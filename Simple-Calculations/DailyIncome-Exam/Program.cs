using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyIncome_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            var dailyIncome = double.Parse(Console.ReadLine());
            var dollarsToLev = double.Parse(Console.ReadLine());

            var monthSalary = workDays * dailyIncome;
            var yearSalary = monthSalary * 12 + monthSalary * 2.5;
            var yearTaxes = yearSalary * 0.25;
            var netSalary = yearSalary - yearTaxes;
            var salaryInLeva = netSalary * dollarsToLev;
            var average = salaryInLeva / 365;
            Console.WriteLine(Math.Round(average, 2));




        }
    }
}