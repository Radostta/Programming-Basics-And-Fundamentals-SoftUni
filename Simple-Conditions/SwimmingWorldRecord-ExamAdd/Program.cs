using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingWorldRecord_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldSecs = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secsPerMeter = double.Parse(Console.ReadLine());

            double newSecs = (distance * secsPerMeter);
            double resistanceSecs = ((int)distance / 15) * 12.50;
            newSecs += resistanceSecs;

            if (oldSecs > newSecs)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {newSecs:f2} seconds.");
            }
            else if (oldSecs <= newSecs)
            {
                Console.WriteLine($"No, he failed! He was {(newSecs - oldSecs):f2} seconds slower.");
            }
        }
    }
}
