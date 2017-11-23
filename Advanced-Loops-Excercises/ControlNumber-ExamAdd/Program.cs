using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            int combinations = 0;
            int sum = 0;

            for (int first = 1; first <= n; first++)
            {
                for (int second = m; second >= 1; second--)
                {
                    combinations++;
                    sum += (first * 2 + second * 3);
                    if (sum >= control) break;
                }
                if (sum >= control) break;
            }

            if (sum >= control)
            {
                Console.WriteLine($"{combinations} moves");
                Console.WriteLine($"Score: {sum} >= {control}");
            }
            else if (sum < control)
            {
                Console.WriteLine($"{combinations} moves");
            }

            //int firstFinish = int.Parse(Console.ReadLine());
            //int secondStart = int.Parse(Console.ReadLine());
            //int controlSum = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int moves = 0;
            ////bool isFinished = false;            

            //for (int first = 1; first <= firstFinish; first++)
            //{
            //    for (int second = secondStart; second >= 1; second--)
            //    {
            //        moves++;
            //        sum += (first * 2 + second * 3);
            //        if (sum >= controlSum)
            //        {                        
            //            break;
            //        }
            //    }
            //    if (sum >= controlSum) continue; 
            //}

            //if (sum >= controlSum)
            //{
            //    Console.WriteLine($"{moves} moves");
            //    Console.WriteLine($"Score: {sum} >= {controlSum}");
            //}
            //else Console.WriteLine($"{moves} moves");
        }
    }
}
