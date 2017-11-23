using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            double cupsNeeded = double.Parse(Console.ReadLine());
            double workersCount = double.Parse(Console.ReadLine());
            double workDays = double.Parse(Console.ReadLine());

            double workHours = workDays * 8 * workersCount;
            double cups = Math.Floor(workHours / 5);            
            double difference = Math.Abs(cups - cupsNeeded);
            double diffMoney = difference * 4.20;

            if (cups >= cupsNeeded)
            {
                Console.WriteLine($"{diffMoney:f2} extra money");
            }
            else
            {
                Console.WriteLine($"Losses: {diffMoney:f2}");
            }


        }
    }
}
