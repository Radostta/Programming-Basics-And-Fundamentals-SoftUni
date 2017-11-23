using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var secondsSum = num1 + num2 + num3;
            //var minutes = 0;

            var seconds = secondsSum % 60;
            var minutes = secondsSum / 60;

            if (seconds < 10)
            {
                // Console.WriteLine($"{minutes}:{seconds:d2}");
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");

            }

            // if (secondsSum > 59)
            //  {
            //      minutes++;
            //      secondsSum = secondsSum - 60;
            //  }
            //  if (secondsSum > 59)
            //  {
            //      minutes++;
            //      secondsSum = secondsSum - 60;
            //  }
            //  if (secondsSum < 10)
            //  {
            //      Console.WriteLine(minutes + ":0" + secondsSum);
            //  }
            //  else
            //  {
            //      Console.WriteLine(minutes + ":" + secondsSum);
            //  }
        }
    }
}
