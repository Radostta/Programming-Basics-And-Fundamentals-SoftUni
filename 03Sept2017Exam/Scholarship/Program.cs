using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double avrGrades = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            double socialSch = minWage * 0.35;
            double excSch = avrGrades * 25.00;

            if (avrGrades < 4.50) Console.WriteLine("You cannot get a scholarship!");
            else if (avrGrades > 4.50 && avrGrades < 5.50)
            {
                if (income > minWage) Console.WriteLine("You cannot get a scholarship!");
                else Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socialSch));
            }
            else if (avrGrades >= 5.50 && income < minWage)
            {
                if (socialSch > excSch) Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socialSch));
                else Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(excSch));
            }
            else if (avrGrades > 5.50 && income >= minWage)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(excSch));
            }


        }
    }
}