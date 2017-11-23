using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15MinS_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var timeInMins = hours * 60 + minutes + 15;
            hours = timeInMins / 60;
            minutes = timeInMins % 60;

            if (hours >= 24)
            {
                hours = hours - 24;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        

          // minutes = minutes + 15;
          //
          // if (minutes >= 60)
          // {
          //     hours = hours + 1;
          //     minutes = minutes - 60;
          // }
          //
          // if (hours >= 24)
          // {
          //     hours = hours - 24;
          //
          // }
          //
          // Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
