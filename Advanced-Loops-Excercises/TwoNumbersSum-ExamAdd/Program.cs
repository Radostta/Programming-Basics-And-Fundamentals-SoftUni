using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersSum_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isFound = false;
            int currentFirst = 0;
            int currentSecond = 0;
            int currentCombination = 0;


            for (int first = start; first >= finish; first--)
            {
                for (int second = start; second >= finish; second--)
                {
                    combinations++;
                    if (first + second == sum)
                    {
                        currentFirst = first;
                        currentSecond = second;
                        currentCombination = combinations;
                        isFound = true;
                        break;
                    }
                }
                if (isFound == true) break;
            }

            if (isFound == false) Console.WriteLine($"{combinations} combinations - neither equals {sum}");
            else if (isFound == true) Console.WriteLine($"Combination N:{currentCombination} ({currentFirst} + {currentSecond} = {sum})");

        }
    }
}
