using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmailsUsingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string dNframeworkInputPath = @"..\..\Input.txt";
            string[] lines = File.ReadAllLines(dNframeworkInputPath);
            
            string result = "";

            for (int i = 0; i < lines.Length; i += 2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }

                var name = lines[i];
                var email = lines[i + 1];

                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }

                var output = $"{name} -> {email}" + Environment.NewLine;
                result += output;
            }

            string dNframeworkOutputPath = @"..\..\Output.txt";
            File.WriteAllText(dNframeworkOutputPath, result);
            
        }
    }
}
