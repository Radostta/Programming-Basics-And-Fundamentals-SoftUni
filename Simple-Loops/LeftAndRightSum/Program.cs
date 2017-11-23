using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    leftSum += num;
                }
                else
                {
                    rightSum += num;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }



        }
    }
}
