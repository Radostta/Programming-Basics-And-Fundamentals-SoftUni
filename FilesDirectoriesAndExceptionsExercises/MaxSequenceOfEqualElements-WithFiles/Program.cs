using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements_WithFiles
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
                var numbers = lines[index].Split(' ').Select(int.Parse).ToArray();
                var length = 1;
                var bestLength = 0;
                var bestIndex = 0;

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestIndex = i - length + 1;
                    }
                }
                
                for (int i = bestIndex; i < bestIndex + bestLength; i++)
                {
                    result += numbers[i] + " ";
                }
                result += Environment.NewLine;
            }

            string dNframeworkOutputPath = @"..\..\Outputs.txt";
            File.WriteAllText(dNframeworkOutputPath, result);
        }
    }
}
