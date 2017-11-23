using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            double juniors = double.Parse(Console.ReadLine());
            double seniors = double.Parse(Console.ReadLine());
            string track = Console.ReadLine();
            double sum = 0;
            double allMembers = juniors + seniors;

            if (track == "trail")
            {
                sum += juniors * 5.50 + seniors * 7.00;
            }
            else if (track == "cross-country")
            {
                if (allMembers >= 50)
                {
                    sum = (juniors * 8.00 + seniors * 9.50) - (juniors * 8.00 + seniors * 9.50) * 0.25;
                }
                else
                {
                    sum = juniors * 8.00 + seniors * 9.50;
                }
            }
            else if (track == "downhill")
            {
                sum += juniors * 12.25 + seniors * 13.75;
            }
            else if (track == "road")
            {
                sum += juniors * 20.00 + seniors * 21.50;
            }

            sum -= sum * 0.05;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
