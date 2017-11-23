using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var result = "";

            for (int i = 0; i < input.Length; i++)
            {
                result = ConvertToUnicode(input[i]);
                Console.Write(result);
            }
            Console.WriteLine();
        }

        private static string ConvertToUnicode(char ch)
        {
            return "\\u" + ((int)ch).ToString("x4");
        }
    }
}
