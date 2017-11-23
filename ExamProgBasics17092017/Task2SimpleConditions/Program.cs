using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2SimpleConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double time = 1 / (1 / first + 1 / second + 1 / third);
            time += time * 0.15;

            double difference = Math.Abs(hours - time);

            Console.WriteLine($"Cleaning time: {time:f2}");
            if (time <= hours)
            {                
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(difference)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(difference)} hours.");
            }

           
        }
    }
}
