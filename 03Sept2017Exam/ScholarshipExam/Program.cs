using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grades = double.Parse(Console.ReadLine());
            double wage = double.Parse(Console.ReadLine());
            string status = "";

            if (income < wage)
            {
                if (grades < 4.50) status = "no";
                else if (grades > 4.50 && grades < 5.50) status = "social";
                else if (grades >= 5.50) status = "both";

            }
            else if (income >= wage)
            {
                if (grades < 5.50) status = "no";
                else if (grades >= 5.50) status = "excellent";
            }

            double socSc = wage * 0.35;
            double exSc = grades * 25;

            if (status == "no") Console.WriteLine("You cannot get a scholarship!");
            else if (status == "social") Console.WriteLine($"You get a Social scholarship {Math.Floor(socSc)} BGN");
            else if (status == "excellent") Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(exSc)} BGN");
            else if (status == "both")
            {
                if (exSc < socSc) Console.WriteLine($"You get a Social scholarship {Math.Floor(socSc)} BGN");
                else if (exSc >= socSc) Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(exSc)} BGN");
            }
        }
    }
}
