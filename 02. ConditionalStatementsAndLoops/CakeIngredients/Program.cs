using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)            
        {
            int ingredinents = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Bake!")
                {
                    break;
                }
                ingredinents++;

                Console.WriteLine($"Adding ingredient {command}.");
            }

            Console.WriteLine($"Preparing cake with {ingredinents} ingredients.");
        }
    }
}
