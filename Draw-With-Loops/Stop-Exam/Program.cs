using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1)); //draw first line

            int dots = n;
            int dashes = 2 * n - 1;
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', dashes)); //draw top part
                dots--;
                dashes = dashes + 2;
            }
            int sideDashes = (dashes - 5) / 2;
            Console.WriteLine("{0}//{1}STOP!{1}\\\\{0}", new string('.', dots), new string('_', sideDashes)); //draw middle line
        
            for (int lowerDots = 0; lowerDots <= n - 1; lowerDots++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', lowerDots), new string('_', dashes)); //draw top part                
                dashes = dashes - 2;
            }

        }
    }
}
