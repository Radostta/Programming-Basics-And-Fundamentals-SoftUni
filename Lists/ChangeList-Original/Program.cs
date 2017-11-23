using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputCommands = input.Split().Select(int.Parse).ToList(); //inputTokens

            while (input != "Odd" && input != "Even")
            {
                var command = input.Split().ToList();

                if (command[0] == "Delete")
                {
                    int value = int.Parse(command[1]);
                    inputCommands.RemoveAll(x => x == value);
                }
                else if (command[0] == "Insert")
                {
                    var value = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    inputCommands.Insert(position, value);
                }

                input = Console.ReadLine();
            }

            if (input == "Even")
            {
                inputCommands = inputCommands.Where(x => x % 2 == 0).ToList();
                Console.WriteLine(String.Join(" ", inputCommands));
            }
            else
            {
                inputCommands = inputCommands.Where(x => x % 2 != 0).ToList();
                Console.WriteLine(String.Join(" ", inputCommands));
            }
        }
    }
}
