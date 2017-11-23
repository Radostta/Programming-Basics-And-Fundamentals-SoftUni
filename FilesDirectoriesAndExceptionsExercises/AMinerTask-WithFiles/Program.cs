using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask_WithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string dNframeworkInputPath = @"..\..\Input.txt";
            string[] lines = File.ReadAllLines(dNframeworkInputPath);

            string result = "";

            for (int index = 0; index < lines.Length; index += 2)
            {
                if (lines[index] == "stop" || lines[index + 1] == "stop")
                {
                    break;
                }

                string ore = lines[index];
                string quantity = lines[index + 1];

                result += $"{ore} -> {quantity}" + Environment.NewLine;
            }
           
            string dNframeworkOutputPath = @"..\..\Output.txt";
            File.WriteAllText(dNframeworkOutputPath, result);
        }
    }
}
