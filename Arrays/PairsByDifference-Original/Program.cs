using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());

            var count = 0;

            for (int n1 = 0; n1 < numbers.Length; n1++)
            {
                int currentNum = numbers[n1];

                for (int n2 = 0; n2 < numbers.Length; n2++) //or n2 = n1+ 1 and... combination of each i with the next one
                {
                    int secondNum = numbers[n2];

                    if (currentNum - secondNum == difference) //...and if (currentNum - secondNum == difference || secondNum - currentNum == difference (Math.Abs take too much time)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
