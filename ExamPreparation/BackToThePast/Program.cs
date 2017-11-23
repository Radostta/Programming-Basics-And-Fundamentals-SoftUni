using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double yearCount = double.Parse(Console.ReadLine());
            double age = 18;
            double cost = 0;

            for (int year = 1800; year <= yearCount; year++)
            {               
                if (year % 2 == 0)
                {
                    cost += 12000;
                }
                else
                {
                    cost += 12000 + (50 * age);
                }
                age++;
            }

            double difference = Math.Abs(money - cost);

            if (cost <= money)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {difference:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {difference:f2} dollars to survive.");
            }
        }
    }
}
