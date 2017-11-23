using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm_Exam_Book
{
    class Program
    {
        static void Main(string[] args)
        {
        //  var projectHours = int.Parse(Console.ReadLine());
        //  var availableDays = int.Parse(Console.ReadLine());
        //  var overtimeWorkers = int.Parse(Console.ReadLine());
        //
        //  var workDays = availableDays * 0.90;
        //  var overtime = overtimeWorkers * 2 * availableDays;
        //  var workHours = Math.Floor(workDays * 8 + overtime);
        //
        //  if (workHours >= projectHours)
        //  {
        //      Console.WriteLine("Yes!{0} hours left.", workHours - projectHours);
        //  }
        //  else
        //  {
        //      Console.WriteLine("Not enough time!{0} hours needed.", projectHours - workHours);
        //  }


         var projectHours = int.Parse(Console.ReadLine());
         var projectDays = int.Parse(Console.ReadLine());
         var trainingDays = projectDays * 0.10;
         var daysLeft = projectDays - trainingDays;
         
         var workersOvertime = int.Parse(Console.ReadLine());
         var hoursOvertime = 2 * projectDays * workersOvertime;
         var totalHours = Math.Floor(8 * daysLeft + hoursOvertime);
         var difference = Math.Abs(projectHours - totalHours);

         
         if (totalHours >= projectHours)
         {
             Console.WriteLine("Yes!{0} hours left.", difference);
         }
         else
         {
             Console.WriteLine("Not enough time!{0} hours needed.", difference);
         }

        }
    }
}
