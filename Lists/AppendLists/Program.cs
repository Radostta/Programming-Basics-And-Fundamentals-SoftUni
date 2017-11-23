using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            var joined = "";

            for (int i = inputLine.Count - 1; i >= 0; i--)
            {
                joined += inputLine[i] + " ";
            }

            var result = joined.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
