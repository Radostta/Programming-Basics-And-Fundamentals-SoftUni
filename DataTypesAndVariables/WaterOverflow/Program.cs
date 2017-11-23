using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            const int tank = 255;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentLiters = int.Parse(Console.ReadLine());
                sum += currentLiters;
                if (sum > tank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= currentLiters;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
