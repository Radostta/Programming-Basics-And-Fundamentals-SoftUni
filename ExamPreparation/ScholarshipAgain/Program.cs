using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double excellent = 0;
            double social = 0;

            if (grade >= 5.50)
            {
                excellent = grade * 25;
            }
            if (grade > 4.50 && income < minSalary)
            {
                social = minSalary * 0.35;
            }
            
            if (excellent == 0 && social == 0)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
            else if (social < excellent)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellent)} BGN");
            }
            else
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
            }                        
            
        }
    }
}
