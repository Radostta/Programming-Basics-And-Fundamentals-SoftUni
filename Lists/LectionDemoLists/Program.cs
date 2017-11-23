using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectionDemoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //REMOVE ELEMENTS WITHOUT RISK OF GOING OUT OF BOUNDS IN REST OF CYCLE - WE SET THE VALUE TO 0 INSTEAD OF REMOVING IT
            
            //TAKE - takes from the list NUMBERS an int as count how many to take -> here it is as [0] in the second list- var result = numbers.Take(commandArgs[0]).ToList();

            //PRINTING ON NEW LINES:
            //nameOfList.ForEach(Console.WriteLine); - without the brackets!
            //nameOfList.ForEach(x => Console.WriteLine("Pesho " + x));


            //LAMBDA FUNCTIONS: - actions from RIGHT TO LEFT

            //Remove all even numbers - listName.RemoveAll(x => x % 2 == 0);
            //Remove all negative numbers - listName.RemoveAll(i => i < 0);
            //Remove all from 20 to 40 - listName.RemoveAll(x => x > 20 && x < 40);

            //Find all - var evenNumbers = listName.FindAll(x => x % 2 == 0);

            //CONTAINS
            //bool result = listName.Contains(30); - returns true or false

            //TERNARY EXPRESSION WITH .CONTAINS- BETTER
            //Console.WriteLine(result.Contains(commandArgs[2]) ? "YES!" : "NO!");

            //COUNT
            //var total = listOfNumbers.Count(x => x == 30); - count all such elements in the list

            //SELECT
            //.Select(a => int.Parse(new string(a.Reverse().ToArray())))
            //example:Console.WriteLine(Console.ReadLine()
                //.Split()
                //.Select(a => int.Parse(new string(a.Reverse().ToArray())))
                //.Sum());
            //We read, take each element, reverse each string, turn it into an array, then we string it, then we parse it, and sum its elements.

            //WHERE - leave list with values of such condition

            //SORTING

            //var names = new List<string>() { "Boris", "Angel", "Nakov"};
            //names.Sort(); // it matters if it's small or capital letters - taken from Unicode (we can also sort .,etc symbols)
            //names.Sort(); names.Reverse(); // this will also reverse them
            //Console.WriteLine(string.Join(", ", names));

            //STABLE AND UNSTABLE SORTING - default in c# is stable
            //Stable - guaranteed to stay in the same order they have been in - they will not be swapped
            //Unstable - on what other criteria to sort two equal values

            //READING FROM THE CONSOLE:

            //READING FROM ONE LINE (we can as well do it with arrays):

            //string inputLine = Console.ReadLine();

            //string[] items1 = inputLine.Split(' '); //- with only one divider
            //string[] items = inputLine.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            ////CONVERTING TO INT LIST:
            //List<int> integers = new List<int>();
            //foreach (var item in items)
            //{
            //    integers.Add(int.Parse(item));
            //}

            ////now we print the integers with for or foreach and we sum them:

            //int sum = 0;
            //for (int i = 0; i < integers.Count; i++)
            //{
            //    Console.WriteLine(integers[i]);
            //    sum += integers[i];
            //}
            //Console.WriteLine(sum);

            //THE SHORT WAY:
            //string values = Console.ReadLine();
            //List<string> items = values.Split(' ').ToList();
            //var numbers = values.Split(' ').Select(int.Parse).ToList();

            //THE REAL USAGE OF LISTS - UNKNOWN ENTRIES:

            //List<string> names = new List<string>();
            //string currentName = Console.ReadLine();
            //while (currentName.Length != 0) //or (inputLine != "")
            //{
            //    names.Add(currentName);
            //    currentName = Console.ReadLine(); // or int.Parse(cr) if we wanted integers
            //}

            //The same as in arrays: WITH KNOWN ENTRIES:
            //int n = int.Parse(console.readline()); - to know how many elements to get from the console
            //List<int> integers = new List<int>(); - to initialize the list
            //for (int i = 0; i < n; i++)
            //{
            //    integers.Add(int.Parse(Console.ReadLine());
            //}

            //WE CAN INITIALLY GIVE IT SIZE (but it is CAPACITY not COUNT):
            //int namesCount = int.Parse(console.readline());
            //List<int> integers = new List<int>(namesCount);

            //The List is a data structure

            //4 THINGS every data structure can do: add, insert, remove, find

            //List<string> names = new List<string>();
            //names.Add("Sofia");
            //Console.WriteLine(names[0]); //output: Sofia

            //Console.WriteLine(names.Count); //prints the length of the list

            //names = ...  - ctrl . on names to generate local valuable

            //"new" in most programming languages means "give me dynamic memory(in the heap)

            //CREATING A LIST:

            //var names = new List<string>();

            //names.Add("Peter");
            //names.Add("Maria");
            //names.Add("George");

            //REMOVE RANGE
            //AddRange(nameOfAnotherList) - add all the other elements to the list
            //result.RemoveRange(0, commandArgs[1]);


            //CHANGE VALUES
            //names[1] = "Ivan";

            //REMOVE
            //names.Remove("Maria"); - REMOVES THE FIRST ONE IF THERE ARE MORE MARIAS
            //REMOVEALL - removes all the Marias - but this method takes predicates not valuues            
            //or
            //names.RemoveAt[1]; - removes "Maria"

            //REMOVE ALL WITH CYCLE:
            //while (names.IndexOf("Berlin") != - 1) - when it cannot find something, it returns index -1
            //{
            //namespace.Remove("Berlin");
            //REMOVE returns true of false whether it found sth to remove, so we can say:

            //while (names.Remove("Berlin"))
            //{
            //}

            //INSERT
            //names.Insert(1, "Berlin") - we want it btw 0 and 1 - this inserts Berlin at 1 position and the rest positions move to the right

            //FIND by index
            //find on which index position is what we are looking for
            //names.Find("Berlin") - output: 1

            //MIN MAX
            //names.Min - returns the min element as a value (not as an index)
            //for example - string minName = names.Min(); - return the first name - lexigraphically be char values in alphabet

            //MIN MAX can have parameters by which to evaluate - size, order, etc.)

            //INDEXOF
            //same - names.IndexOf("Berlin") - output 1

            //FINDING SOMETHING WITHOUT THE METHOD FIND

            //for (int i = 0; i < names.Count; i++)
            //{
            //    if (names[i] == "Berlin")
            //    {
            //        Console.WriteLine("Berlin found at index" + i);
            //        break;
            //    }
            //}

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            ////output: Peter George on new lines

            //Console.WriteLine(string.Join(", ", names));

            //output: Peter, George

            //SORT - sorts the elements by their natural order
            //SORT is not the best, changes two algorithms
            //We need to learn to sort by hand, all different types:
            //Main types to learn: QUICK SORT and MERGE SORT


            /////////////////////////
            //cw(names.Capacity) - prints the whole memory the list has prepared as numbers of positoins - starts with 4 in c#
            //we can lower the capacity:
            //names.Capacity = name.Count; 

            //STRUCTURE: List<int> listName
            //List - a key word like int[] in arrays but it is a generic class
            //<> - holds the type of the list as in [] for the arrays
            //name of the list

            //there are different types of Lists
            //the list is an array, that can vary in size -> we can add or remove elements
            //the commands are the same, but differ by names - the lists are with .count, the arrays are with .length

            //the list double in size by powers in 2 when it needs to enlarge - so it takes more memory than the array

            //LinkedList does not have indexes so we can not use a for cycle, but foreach, which uses enumerators

        }
    }
}
