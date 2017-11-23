using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double scholarshipSocial = 0;
            double scholarshipForGrade = 0;

            if (income < minimalSalary && grade > 4.5)
            {
                scholarshipSocial = minimalSalary * 0.35;
            }

            if (grade >= 5.5)
            {
                scholarshipForGrade = grade * 25;
            }

            if (scholarshipSocial == 0 && scholarshipForGrade == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (scholarshipSocial > scholarshipForGrade)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(scholarshipSocial)} BGN");
            }
            else
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarshipForGrade)} BGN");
            }
        }
    }
}
