using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputTokens = input.Split().Select(int.Parse).ToList();

            while (input != "Even" && input != "Odd")
            {
                var command = input.Split().ToList();

                if (command[0] == "Delete")
                {
                    var element = int.Parse(command[1]);
                    inputTokens.RemoveAll(n => n == element);
                }
                else if (command[0] == "Insert")
                {
                    var element = int.Parse(command[1]);
                    var index = int.Parse(command[2]);
                    inputTokens.Insert(index, element);
                }

                input = Console.ReadLine();
            }

            if (input == "Even")
            {
                inputTokens = inputTokens.Where(n => n % 2 == 0).ToList();
                Console.WriteLine(string.Join(" ", inputTokens));
            }
            else if (input == "Odd")
            {
                inputTokens = inputTokens.Where(n => n % 2 != 0).ToList();
                Console.WriteLine(string.Join(" ", inputTokens));
            }
        }
    }
}
