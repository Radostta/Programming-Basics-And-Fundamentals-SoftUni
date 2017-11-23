using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters_WithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string dNframeworkInputPath = @"..\..\Inputs.txt";
            string[] lines = File.ReadAllLines(dNframeworkInputPath);

            string result = "";

            char[] alphabet = new char[26];
            char letter = 'a';

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = letter;
                letter++;
            }

            for (int index = 0; index < lines.Length; index++)
            {
                string inputString = lines[index];
                var charArray = inputString.ToCharArray();
                
                for (int ch = 0; ch < charArray.Length; ch++)
                {
                    if (alphabet.Contains(charArray[ch]))
                    {
                        result += charArray[ch] + " -> " + Array.IndexOf(alphabet, charArray[ch]) + Environment.NewLine;
                    }
                }
                result += Environment.NewLine;
            }

            string dNframeworkOutputPath = @"..\..\Outputs.txt";
            File.WriteAllText(dNframeworkOutputPath, result);
        }
    }
}
