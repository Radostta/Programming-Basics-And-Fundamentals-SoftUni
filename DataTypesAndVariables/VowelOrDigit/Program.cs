using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = 0;

            if (int.TryParse(input, out num))
            {
                Console.WriteLine("digit");
            }
            else if (input == "a" || input == "o" || input == "u" || input == "y" || input == "i" || input == "e")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
