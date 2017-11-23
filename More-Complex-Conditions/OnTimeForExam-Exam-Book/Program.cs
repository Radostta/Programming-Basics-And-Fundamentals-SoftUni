using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam_Exam_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //ERROR:
            var examHours = int.Parse(Console.ReadLine());
            var examMinutes = int.Parse(Console.ReadLine());
            var arrivalHours = int.Parse(Console.ReadLine());
            var arrivalMinutes = int.Parse(Console.ReadLine());

            var examTime = examHours * 60 + examMinutes;
            var arrivalTime = arrivalHours * 60 + arrivalMinutes;
            var minutesDifference = arrivalTime - examTime;
            var hh = Math.Abs(minutesDifference / 60);
            var mm = Math.Abs(minutesDifference % 60);
            var absTime = Math.Abs(minutesDifference);

             if (minutesDifference > 0)
            {
                if (minutesDifference <= 59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{absTime} minutes after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hh}:{mm:d2} hours after the start");
                }
            }
            else if (minutesDifference == 0)
            {
                Console.WriteLine("On time");
            }
            else if (minutesDifference >= -30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{absTime} minutes before the start");
            }
            else if (minutesDifference < -30)
            {
                if (minutesDifference > -59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{absTime} minutes before the start");
                }
                else if (minutesDifference <= -60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hh}:{mm:d2} hours before the start");
                }
            }
           

           


            // var hoursExam = int.Parse(Console.ReadLine());
            // var minsExam = int.Parse(Console.ReadLine());
            // var hoursArrival = int.Parse(Console.ReadLine());
            // var minsArrival = int.Parse(Console.ReadLine());
            //
            // var totalminsExam = hoursExam * 60 + minsExam;
            // var totalminsArrival = hoursExam * 60 + minsExam;
            //
            // var minutesDifference = totalminsArrival - totalminsExam;
            // 
            // var late = "Late";
            // var onTime = "On time";
            // var early = "Early";
            //
            // var studentArrival = late;
            //
            // if (minutesDifference > -30)
            // {
            //     studentArrival = early;
            // }
            // else if (minutesDifference <= 30)
            // {
            //     studentArrival = onTime;
            // }
            //
            // var result = string.Empty;
            //
            // if (minutesDifference != 0)
            // {
            //     var mm = Math.Abs(minutesDifference % 60);
            //     var hh = Math.Abs(minutesDifference / 60);
            //
            //     if (hh > 0)
            //     {
            //         result = string.Format("{0}:{1:00} hours", hh, mm);
            //     }
            //     else
            //     {
            //         result = mm + "minutes";
            //     }
            //     if (minutesDifference < 0)
            //     {
            //         result = result + " before the start";
            //     }
            //     else
            //     {
            //         result = result + " after the start";
            //     }
            // }
            // 
            // if (!string.IsNullOrEmpty(result))
            // {
            //     Console.WriteLine(result);
            // }


        }
    }
}
