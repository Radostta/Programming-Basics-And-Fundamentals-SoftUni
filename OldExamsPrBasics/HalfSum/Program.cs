using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }

            int difference = Math.Abs(leftSum - rightSum);

            if (rightSum == leftSum) Console.WriteLine($"Yes, sum={rightSum}");
            else Console.WriteLine($"No, diff={difference}");


        }
    }
}
