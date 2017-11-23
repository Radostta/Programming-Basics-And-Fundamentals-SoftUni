using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsWithFiles
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
                var numbers = lines[index].Split().Select(int.Parse).ToArray();

                bool isFound = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int[] leftSide = numbers.Take(i).ToArray();
                    int[] rightSide = numbers.Skip(i + 1).ToArray();

                    if (leftSide.Sum() == rightSide.Sum())
                    {
                        result += i.ToString() + Environment.NewLine;
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    result += "no" + Environment.NewLine;
                }
            }

            string dNframeworkOutputPath = @"..\..\Outputs.txt";
            File.WriteAllText(dNframeworkOutputPath, result);
        }
    }
}
