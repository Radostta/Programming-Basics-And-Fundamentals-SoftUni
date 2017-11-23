using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int daysInMonth = 31;

            if (month == 2) daysInMonth = 28;
            else if (month == 4 || month == 6 || month == 9 || month == 11) daysInMonth = 30;

            days += 5;
            if (days > daysInMonth)
            {
                days -= daysInMonth;
                month++;
            }                
            if (month > 12) month = 1;

            Console.WriteLine($"{days}.{month:d2}");


        }
    }
}
