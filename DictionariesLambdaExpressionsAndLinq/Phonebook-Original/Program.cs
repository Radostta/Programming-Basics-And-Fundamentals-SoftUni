using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<String, String>(); //commandArgs[1], phone number

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                var commandArgs = input.Split(' '); //[0] command, [1] name , [2] phone number
                var command = commandArgs[0];

                if (command == "A")
                {
                    phonebook[commandArgs[1]] = commandArgs[2];
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(commandArgs[1]))
                    {
                        Console.WriteLine($"{commandArgs[1]} -> {phonebook[commandArgs[1]]}");
                        //foreach (var contact in phonebook)
                        //{
                        //    if (contact.Key == commandArgs[1])
                        //    {
                        //        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                        //    }
                        //}
                    }
                    else
                    {
                        Console.WriteLine($"Contact {commandArgs[1]} does not exist.");
                    }
                }                
            }
        }
    }
}
