using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int dayNum = int.Parse(Console.ReadLine());

            if (dayNum >= 1 && dayNum <= days.Length)
            {
                Console.WriteLine(days[dayNum - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
                       
        }
    }
}
