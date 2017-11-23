using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersSalary_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double lectionCount = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double budgetPerLection = budget / lectionCount;
            double salaryJelev = 0.00;
            double salaryRoYaL = 0.00;
            double salaryRoli = 0.00;
            double salaryTrofon = 0.00;
            double salarySino = 0.00;
            double salaryOthers = 0.00;

            for (int currentLection = 0; currentLection < lectionCount; currentLection++)
            {
                string lectorName = Console.ReadLine();

                if (lectorName == "Jelev")
                {
                    salaryJelev += budgetPerLection;
                }
                else if (lectorName == "RoYaL")
                {
                    salaryRoYaL += budgetPerLection;
                }
                else if (lectorName == "Roli")
                {
                    salaryRoli += budgetPerLection;
                }
                else if (lectorName == "Trofon")
                {
                    salaryTrofon += budgetPerLection;
                }
                else if (lectorName == "Sino")
                {
                    salarySino += budgetPerLection;
                }
                else
                {
                    salaryOthers += budgetPerLection;
                }
            }

            Console.WriteLine($"Jelev salary: {salaryJelev:f2} lv");
            Console.WriteLine($"RoYaL salary: {salaryRoYaL:f2} lv");
            Console.WriteLine($"Roli salary: {salaryRoli:f2} lv");
            Console.WriteLine($"Trofon salary: {salaryTrofon:f2} lv");
            Console.WriteLine($"Sino salary: {salarySino:f2} lv");
            Console.WriteLine($"Others salary: {salaryOthers:f2} lv");

        }
    }
}
