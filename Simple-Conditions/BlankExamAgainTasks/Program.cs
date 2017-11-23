using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankExamAgainTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var dayTime = Console.ReadLine().ToLower();

            if (km < 20)
            {
                if (dayTime == "day")
                {
                    Console.WriteLine(0.79 * km + 0.70);
                }
                else if (dayTime == "night")
                {
                    Console.WriteLine(0.90 * km + 0.70);
                }
            }

           
            else if (km < 100)
            {
                Console.WriteLine(0.09 * km);
            }
            else
            {
                Console.WriteLine(0.06 * km);

            }

        }
    }
}
