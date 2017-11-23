using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam__Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHours = int.Parse(Console.ReadLine());
            var examMinutes = int.Parse(Console.ReadLine());
            var arrivalHours = int.Parse(Console.ReadLine());
            var arrivalMinutes = int.Parse(Console.ReadLine());

            var examTotalMinutes = examHours * 60 + examMinutes;
            var arrivalTotalMinutes = arrivalHours * 60 + arrivalMinutes;
            var differenceMinutes = arrivalTotalMinutes - examTotalMinutes;

            var early = differenceMinutes < -30;
            var onTime = differenceMinutes <= 0;
            var late = differenceMinutes > 0;

            var absoluteDifference = Math.Abs(differenceMinutes);
            var clockHours = absoluteDifference / 60;
            var clockMinutes = absoluteDifference % 60;

            if (early && differenceMinutes < -59)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0}:{1:d2} hours before the start", clockHours, clockMinutes);
            }
            else if (early)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", absoluteDifference);
            }
            else if (onTime && differenceMinutes < 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", absoluteDifference);

            }
            else if (onTime && differenceMinutes == 0)
            {
                Console.WriteLine("On time");
            }
            else if (late && differenceMinutes <= 59)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", absoluteDifference);
            }
            else if (late && differenceMinutes > 59)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1:d2} hours after the start", clockHours, clockMinutes);
            }
        }
    }
}
