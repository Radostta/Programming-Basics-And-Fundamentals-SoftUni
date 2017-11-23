using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lections = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double lectionBudget = budget / lections;

            double salaryJelev = 0;
            double salaryRoYal = 0;
            double salaryRoli = 0;
            double salaryTrofon = 0;
            double salarySino = 0;
            double salaryOthers = 0;

            for (int currentLection = 1; currentLection <= lections; currentLection++)
            {
                string lector = Console.ReadLine();

                if (lector == "Jelev") salaryJelev += lectionBudget;
                else if (lector == "RoYaL") salaryRoYal += lectionBudget;
                else if (lector == "Roli") salaryRoli += lectionBudget;
                else if (lector == "Trofon") salaryTrofon += lectionBudget;
                else if (lector == "Sino") salarySino += lectionBudget;
                else salaryOthers += lectionBudget;
            }

            Console.WriteLine($"Jelev salary: {salaryJelev:f2} lv");
            Console.WriteLine($"RoYaL salary: {salaryRoYal:f2} lv");
            Console.WriteLine($"Roli salary: {salaryRoli:f2} lv");
            Console.WriteLine($"Trofon salary: {salaryTrofon:f2} lv");
            Console.WriteLine($"Sino salary: {salarySino:f2} lv");
            Console.WriteLine($"Others salary: {salaryOthers:f2} lv");


        }
    }
}
