using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int timeInMin = (num1 * 60 + num2) + 15;
            int hours = timeInMin / 60;
            int minutes = timeInMin % 60;
            
            if (hours >= 24)
            {
                hours -= 24;
            }
            
                Console.WriteLine($"{hours}:{minutes:d2}");
            
        }
    }
}
