using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            string newNoun;

            bool endsWithY = noun.EndsWith("y");
            bool endsWithOtoZ = noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z");
           
            if (endsWithY)
            {
                newNoun = noun.Remove(noun.Length - 1, 1);
                Console.WriteLine(newNoun + "ies");
            }
            else if (endsWithOtoZ)
            {
                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun + "s");
            }
           
        }
    }
}
