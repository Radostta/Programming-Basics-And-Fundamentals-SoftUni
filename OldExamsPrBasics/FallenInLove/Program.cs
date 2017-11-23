using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top part
            Console.WriteLine("##{0}##{0}##", new string('.', 2 * n));

            int outsideDotsCount = 2 * n - 2;
            int middleDotsCount = 2;

            for (int row = 0; row < n - 1; row++)
            {
                string waves = new string('~', row + 1);               

                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", waves, new string('.', outsideDotsCount), new string('.', middleDotsCount));
                
                outsideDotsCount -= 2;
                middleDotsCount += 2;
            }

            //middle part
            outsideDotsCount = 1;
            middleDotsCount = 2 * n;
            int wavesCount = n;

            for (int row = 0; row < n; row++)
            {
                string outsideDots = new string('.', outsideDotsCount);
                string waves = new string('~', wavesCount);
                string middleDots = new string('.', middleDotsCount);

                Console.WriteLine("{1}#{0}#{2}#{0}#{1}", waves, outsideDots, middleDots);

                outsideDotsCount += 2;
                wavesCount -= 1;
                middleDotsCount -= 2;
            }

            //bottom part
            Console.WriteLine("{0}####{0}", new string('.', 2 * n + 1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}##{0}", new string('.', 2 * n + 2));
            }


        }
    }
}
