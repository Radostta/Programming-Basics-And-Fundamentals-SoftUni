using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber_WithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string dNframeworkInputPath = @"..\..\Inputs.txt";
            string[] lines = File.ReadAllLines(dNframeworkInputPath);

            string result = "";

            for (int index = 0; index < lines.Length; index++)
            {
                int[] numbers = lines[index].Split(' ').Select(int.Parse).ToArray();
                int currentNumber = 0;
                int number = 0;
                bool areDifferent = true;

                int biggestCount = 1;

                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    int currentCount = 1;

                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            currentCount++;
                            currentNumber = numbers[i];
                            areDifferent = false;
                        }
                    }
                    if (currentCount >= biggestCount)
                    {
                        biggestCount = currentCount;
                        number = currentNumber;
                    }
                }

                if (areDifferent)
                {
                    result += numbers[0] + Environment.NewLine;
                }
                else
                {
                    result += number + Environment.NewLine;
                }
            }

            string dNframeworkOutputPath = @"..\..\Outputs.txt";
            File.WriteAllText(dNframeworkOutputPath, result);
        }
    }
}
