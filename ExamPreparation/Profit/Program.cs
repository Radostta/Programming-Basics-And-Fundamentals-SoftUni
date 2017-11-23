using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            double workDaysPerMonth = double.Parse(Console.ReadLine());
            double wagePerDay = double.Parse(Console.ReadLine());
            double usdToBgnCourse = double.Parse(Console.ReadLine());

            double monthSalary = workDaysPerMonth * wagePerDay;
            double wagePerYear = monthSalary * 12 + monthSalary * 2.5;
            wagePerYear -= wagePerYear * 0.25;
            double avrDayWage = wagePerYear / 365;
            avrDayWage *= usdToBgnCourse;

            Console.WriteLine($"{avrDayWage:f2}");


        }
    }
}
