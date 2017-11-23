using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = input.Length / 4;
                
            var firstPart = input.Take(k).Reverse().ToArray();
            var thirdPart = input.Skip(k * 3).Take(k).Reverse().ToArray();

            var row1 = input.Skip(k).Take(k * 2).ToArray();
            var row2 = firstPart.Concat(thirdPart).ToArray();

            var summedRow = row1.Select((x, index) => x + row2[index]);
            
            Console.WriteLine(string.Join(" ", summedRow));

        }
    }
}
