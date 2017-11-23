using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<int> numbers = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            numbers.RemoveAll(i => i < 0);
            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
