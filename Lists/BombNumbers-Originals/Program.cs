using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers_Originals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); //bomb arguments - special number[0] and power[1] on left and right

            int bomb = bombArgs[0];
            int power = bombArgs[1];

            //int bombIndex = numbers.IndexOf(bomb); //finding the bomb index in numbers list

            for (int i = 0; i < numbers.Count; i++)
            {
                //numbers[bombIndex] = 0; //setting the bomb number to 0
                
                if (numbers[i] == bomb)
                {
                    for (int j = i - power; j <= i + power; j++) //scanning the bomb raduis on both sides
                    {
                        if (j >= 0 && j <= numbers.Count - 1)
                        {
                            numbers[j] = 0; //setting both sides plus bomb to 0
                        }                        
                    }                    
                }
            }

            Console.WriteLine(numbers.Sum());


        }
    }
}
