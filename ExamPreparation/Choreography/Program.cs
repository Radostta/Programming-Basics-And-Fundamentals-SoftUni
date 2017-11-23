using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double availDays = double.Parse(Console.ReadLine());

            double stepsPerDay = (steps / availDays);
            double stepsPercent = Math.Ceiling((stepsPerDay / steps) * 100);

            double percentPerDancer = stepsPercent / dancers;

            if (stepsPercent <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentPerDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {percentPerDancer:f2}% steps to be learned per day.");                
            }            
        }
    }
}
