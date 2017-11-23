using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    input.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands[0] == "addMany")
                {
                    List<int> addMany = new List<int>();
                    for (int i = 2; i < commands.Length; i++)
                    {
                        addMany.Add(int.Parse(commands[i]));
                    }
                    input.InsertRange(int.Parse(commands[1]), addMany);

                }
                else if (commands[0] == "contains")
                {

                    bool check = false;
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] == int.Parse(commands[1]))
                        {
                            Console.WriteLine(i);
                            check = false;
                            break;
                        }
                        else
                        {
                            check = true;
                        }
                    }
                    if (check)
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (commands[0] == "remove")
                {
                    input.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(commands[1]); i++)
                    {
                        input.Add(input[0]);
                        input.RemoveAt(0);
                    }
                }
                else if (commands[0] == "sumPairs")
                {
                    List<int> sum = new List<int>();

                    for (int i = 0; i < input.Count; i += 2)
                    {
                        if (i + 1 >= input.Count)
                        {
                            sum.Add(input[input.Count - 1]);
                            break;
                        }
                        int suma = input[i] + input[i + 1];
                        sum.Add(suma);
                    }
                    input = sum;
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
        public static void ShiftLeft<T>(List<T> lst, int shifts)
        {
            for (int i = shifts; i < lst.Count; i++)
            {
                lst[i - shifts] = lst[i];
            }

            for (int i = lst.Count - shifts; i < lst.Count; i++)
            {
                lst[i] = default(T);
            }

            //    var inputTokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            //    var input = Console.ReadLine();

            //    while (input != "print")
            //    {
            //        var command = input.Split().ToList();

            //        if (command[0] == "add")
            //        {
            //            var index = int.Parse(command[1]);
            //            var element = int.Parse(command[2]);
            //            inputTokens.Insert(index, element);
            //        }
            //        else if (command[0] == "addMany")
            //        {
            //            var index = int.Parse(command[1]);
            //            var numbersToAdd = command.Skip(2).Select(int.Parse).ToList();
            //            inputTokens.InsertRange(index, numbersToAdd);
            //        }
            //        else if (command[0] == "contains")
            //        {
            //            var element = int.Parse(command[1]);
            //            if (inputTokens.Contains(element))
            //            {
            //                Console.WriteLine(inputTokens.IndexOf(element));
            //            }
            //            else
            //            {
            //                Console.WriteLine("-1");
            //            }
            //        }
            //        else if (command[0] == "remove")
            //        {
            //            var index = int.Parse(command[1]);
            //            inputTokens.RemoveAt(index);
            //        }
            //        else if (command[0] == "shift")
            //        {
            //            //var rotations = int.Parse(command[1]);
            //            //for (int i = 0; i < rotations; i++)
            //            //{
            //            //    RotateList(inputTokens);
            //            //}
            //            int number = int.Parse(command[1]);
            //            var rem = inputTokens.Take(number).ToList();
            //            inputTokens.RemoveRange(0, number);
            //            inputTokens.AddRange(rem);
            //        }
            //        else if (command[0] == "sumPairs")
            //        {
            //            inputTokens = SumPairs(inputTokens);
            //        }

            //        input = Console.ReadLine();
            //    }

            //    Console.WriteLine($"[{string.Join(", ", inputTokens)}]");

            //}
            //static List<int> RotateList(List<int> list)
            //{
            //    var lastElement = list[0];

            //    for (int i = 0; i < list.Count - 1; i++)
            //    {
            //        list[i] = list[i + 1];
            //    }
            //    list[list.Count - 1] = lastElement;

            //    return list;
            //}

            //static List<int> SumPairs(List<int> list)
            //{
            //    var result = new List<int>();

            //    if (list.Count % 2 == 0)
            //    {
            //        for (int i = 0; i < list.Count - 1; i += 2)
            //        {
            //            result.Add(list[i] + list[i + 1]);
            //        }
            //    }
            //    else
            //    {
            //        for (int i = 0; i < list.Count - 1; i += 2)
            //        {
            //            result.Add(list[i] + list[i + 1]);
            //        }
            //        result.Add(list[list.Count - 1]);
            //    }

            //    return result;

        }
    }
}
