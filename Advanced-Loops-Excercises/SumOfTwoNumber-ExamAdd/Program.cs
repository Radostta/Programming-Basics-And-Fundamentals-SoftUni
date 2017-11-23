using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumber_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int finishNumber = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int combination = 0;
            bool isFound = false;
            int currentFirst = 0;
            int currentSecond = 0;
            int currentCombination = 0;

            for (int first = startNumber; first <= finishNumber; first++)
            {
                for (int second = startNumber; second <= finishNumber; second++)
                {
                    combination++;
                    if (first + second == sum)
                    {
                        currentFirst = first;
                        currentSecond = second;                        
                        currentCombination = combination;
                        isFound = true;
                        break;
                    }                    
                }
                if (isFound == true) break;
            }
            if (isFound == false) Console.WriteLine($"{combination} combinations - neither equals {sum}");
            else if (isFound == true) Console.WriteLine($"Combination N:{currentCombination} ({currentFirst} + {currentSecond} = {sum})");


        }
    }
}
