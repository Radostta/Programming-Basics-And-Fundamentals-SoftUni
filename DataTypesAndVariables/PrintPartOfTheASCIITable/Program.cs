using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            for (int symbol = start; symbol <= finish; symbol++)
            {
                Console.Write((char)symbol + " ");
            }
        }
    }
}
