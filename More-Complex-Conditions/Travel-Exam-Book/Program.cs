using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Exam_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget * 0.30m:f2}");
                }
                else
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget * 0.70m:f2}");
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget * 0.40m:f2}");
                }
                else
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget * 0.80m:f2}");
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget * 0.90m:f2}");
            }
        }
    }
}
