using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char l1 = char.Parse(Console.ReadLine());
            char l2 = char.Parse(Console.ReadLine());
            char l3 = char.Parse(Console.ReadLine());

            //Console.WriteLine($"{l3}{l2}{l1}");

            char temporary = l1;
            l1 = l3;
            l3 = temporary;

            Console.WriteLine($"{l1}{l2}{l3}");
        }
    }
}
