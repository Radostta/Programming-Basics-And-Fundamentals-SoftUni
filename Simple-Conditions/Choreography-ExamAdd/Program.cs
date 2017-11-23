using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberSteps = double.Parse(Console.ReadLine());
            double numberDancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double stepsPerDayPercent = Math.Ceiling(((numberSteps / days) / numberSteps) * 100.00);
            double percentPerDancer = stepsPerDayPercent / numberDancers;
            
            
            if (stepsPerDayPercent <= 13.00)
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
