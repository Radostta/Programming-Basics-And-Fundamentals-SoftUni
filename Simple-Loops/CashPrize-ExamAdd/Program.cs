using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashPrize_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int partsCount = int.Parse(Console.ReadLine());
            double pointCash = double.Parse(Console.ReadLine());
            int totalPoints = 0;

            for (int currentPart = 1; currentPart <= partsCount; currentPart++)
            {
                int partPoints = int.Parse(Console.ReadLine());

                if (currentPart % 2 == 0)
                {
                    partPoints *= 2;
                }
                totalPoints += partPoints;
            }

            double cash = totalPoints * pointCash;
            Console.WriteLine($"The project prize was {cash:f2} lv.");


        }
    }
}
