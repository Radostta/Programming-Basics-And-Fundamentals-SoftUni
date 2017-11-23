using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var nSequence = new long[n];
            nSequence[0] = 1;            

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                for (int j = i - k; j <= i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sum += nSequence[j];
                    }
                }

                nSequence[i] = sum;
            }

            Console.WriteLine(String.Join(" ", nSequence));

        }
    }
}
