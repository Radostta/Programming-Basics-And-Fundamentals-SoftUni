using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = (minutes + hours * 60) + 30;

            int newHours = totalMinutes / 60;
            int newMinutes = totalMinutes % 60;

            while (newMinutes >= 60)
            {
                newMinutes -= 60;
                newHours++;
            }

            if (newHours >= 24)
            {
                newHours -= 24;
            }

            Console.WriteLine($"{newHours}:{newMinutes:d2}");            
        }
    }
}
