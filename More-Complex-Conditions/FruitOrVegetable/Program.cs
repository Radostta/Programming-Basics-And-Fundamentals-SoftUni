using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            bool isFruit = product == "banana" ||
                            product == "apple" ||
                            product == "kiwi" ||
                            product == "cherry" ||
                            product == "lemon" ||
                            product == "grapes";

            bool isVegetable = product == "tomato" ||
                                product == "cucumber" ||
                                product == "pepper" ||
                                product == "carrot";
            if (isFruit)
            {
                Console.WriteLine("fruit");
            }
            else if (isVegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }


        }
    }
}
