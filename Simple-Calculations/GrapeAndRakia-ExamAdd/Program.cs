using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakia_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double vineyardArea = double.Parse(Console.ReadLine());
            double kgPerSquare = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double grapesHarvest = vineyardArea * kgPerSquare - waste;
            double grapes = grapesHarvest * 0.55;
            double rakia = (grapesHarvest * 0.45) / 7.5;
            double grapesIncome = grapes * 1.50;
            double rakiaIncome = rakia * 9.80;

            Console.WriteLine($"{rakiaIncome:f2}");
            Console.WriteLine($"{grapesIncome:f2}");


        }
    }
}
