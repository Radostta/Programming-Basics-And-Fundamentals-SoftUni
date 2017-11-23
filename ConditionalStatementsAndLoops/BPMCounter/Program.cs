using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double barsCount = numberOfBeats / 4;
            double minutes = numberOfBeats / beatsPerMinute;
            double timeInSeconds = minutes * 60;           
            double seconds = timeInSeconds % 60;

            while (seconds >= 60)
            {
                seconds -= 60;
                minutes++;
            }

            Console.WriteLine($"{Math.Round(barsCount, 1)} bars - {Math.Truncate(minutes)}m {Math.Truncate(seconds)}s");
        }
    }
}
