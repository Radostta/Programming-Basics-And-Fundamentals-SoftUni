using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHh = int.Parse(Console.ReadLine());
            int examMm = int.Parse(Console.ReadLine());
            int arrivalHh = int.Parse(Console.ReadLine());
            int arrivalMm = int.Parse(Console.ReadLine());

            int examMinutes = examMm + examHh * 60;
            int arrivalMinutes = arrivalMm + arrivalHh * 60;
            string status = "";

            int diffMinutes = arrivalMinutes - examMinutes;
            int absDiffMinutes = Math.Abs(diffMinutes);
            int diffHh = absDiffMinutes / 60;
            int diffMm = absDiffMinutes % 60;
            
            while (diffMm >= 60)
            {
                diffMm -= 60;
                diffHh++;
            }

            if (diffMinutes > 0)
            {
                Console.WriteLine("Late");
                if (diffMinutes >= 60) Console.WriteLine($"{diffHh}:{diffMm:d2} hours after the start");
                else Console.WriteLine($"{absDiffMinutes} minutes after the start");
            }
            else if (diffMinutes <= 0 && diffMinutes >= -30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{absDiffMinutes} minutes before the start");
            }
            else if (diffMinutes < -30)
            {
                Console.WriteLine("Early");
                if (diffMinutes <= -60) Console.WriteLine($"{diffHh}:{diffMm:d2} hours before the start");
                else Console.WriteLine($"{absDiffMinutes} minutes before the start");
            }

            
        }
    }
}
