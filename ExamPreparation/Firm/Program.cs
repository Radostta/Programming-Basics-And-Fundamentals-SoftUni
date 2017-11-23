using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededHours = double.Parse(Console.ReadLine());
            double availdays = double.Parse(Console.ReadLine());
            double overtimeWorkersCount = double.Parse(Console.ReadLine());

            double workDays = availdays - availdays * 0.10;
            double availHours = workDays * 8.00;
            double overtimeHours = overtimeWorkersCount * availdays * 2;

            availHours += overtimeHours;
            availHours = Math.Floor(availHours);

            double difference = Math.Abs(availHours - neededHours);

            if (availHours >= neededHours)
            {
                Console.WriteLine($"Yes!{difference} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{difference} hours needed.");
            }


        }
    }
}
