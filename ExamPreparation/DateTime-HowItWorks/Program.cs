using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_HowItWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime testDate = DateTime.Now; // time now + date
            //Console.WriteLine(testDate);

            testDate = testDate.AddYears(2); // after two years
            testDate = testDate.AddYears(-2); // before two years
            Console.WriteLine(testDate.ToString("yyyy")); // search for cd c# custom date format - stack overflow  - this one is year
            Console.WriteLine(testDate.ToString("MM-yyyy"));



        }
    }
}
