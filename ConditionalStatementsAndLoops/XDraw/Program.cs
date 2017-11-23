using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sideCount = 0;
            int midCount = n - 2;
            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', sideCount), new string(' ', midCount));
                sideCount++;
                midCount -= 2;
            }
            Console.WriteLine("{0}x{0}", new string(' ', sideCount));

            for (int row = 0; row < n / 2; row++)
            {
                sideCount--;
                midCount += 2;
                Console.WriteLine("{0}x{1}x{0}", new string(' ', sideCount), new string(' ', midCount));                
            }

        }
    }
}
