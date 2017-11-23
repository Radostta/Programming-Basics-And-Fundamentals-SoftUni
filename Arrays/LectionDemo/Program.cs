using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////STRING to array of chars
            //string input = Console.ReadLine();
            //var inputArray = input.ToCharArray(); //convert the string to an array of chars

            ////CHECKING IF AN ARRAY CONTAINS A VALUE:

            //.Contains indexOf .Last .Skip .Take .Sum()

            //int sum = 1;
            //if (nameOfArray.Contains(sum))

            ////ARRAY OF DIFFERENT TYPES hack:
            //var arr = new dynamic[] { 1, 2, 3, "pesho", DateTime.Now };
            ////print with foreach

            //string[] str = new string[]; - array of strings

            ////reading an array with razdelitel :)
            //string values = cr();
            //string [items] = values.Split(' ');

            ////then we can turn n elements to an array:
            //int[] arr = new int[items.Length];

            ////then we can parse them to numbers:
            //for (int i = 0; i < length; i++)
            //{
            //   arr[i] = int.Parse(items[i]);
            // or int sum += int.Pa...
            // or int[i] numbers = int.Pa (before that we initialize a new array)
            //}


            //PART OF THE FUNCTIONAL WAY OF PROGRAMMING - we take a function with parameters in the brackets - MIXED WITH PROCEDURE WAY OF DOING THINGS 


            //THE EASY WAY:
            // .Select - mapping function to turn a string to a integer - WE NEED TO BE USING SYSTEM.LINQ - Language Integrated Quiry

            //READING AN ARRAY OF NUMBERS FROM STRING:
            //int[] items (OR var nums BUT THEN Select()s => int.Parse(s)) = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            // WHEN WE HAVE MORE THAN ONE INTERVAL  - .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // now to sum the elements in the array: Console.WriteLine(items.Sum()); - THIS IS FROM LINQ - There is also MIN MAX and others

            //if we needed an array of strings, we can just write string[] items = Console.Readline().Split(' ');

            //we can split with nothing - e.g. 158 -> 1 5 8 -> string.Split(new string[] { "" }, StringSplitOptions.None);
            //to be able to parse it later, it has to be int[] items = Console.ReadLine().Select(c => "" + c).Select(int.Parse).ToArray; - this means make each char a string
            //or we can treat it as a string with a for each cycle

            //Printing an array without For cycle:       
            //Console.WriteLine(String.Join(" ", nameOfArray)) -> on one line - String.Join("/r/n/", nameOfArray);
            //printing on new line can also be done this way: string.Join(Environment.NewLine, nameOfArray);

            //IN DIFFERENT COMMANDS:
            //string input = Console.ReadLine();
            //var items = input.Select(c => "" + c);
            //var nums = items.Select(int.Parse);
            //var numbers = nums.ToArray();
            //Console.WriteLine(numbers.Sum());

            ////When you return an array from a method, you return reference, if you want to have the array -> .Clone;
            ///////////////////--------------

            ////Checking if an array is symetric:
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //bool isSymetric = true;
            //for (int i = 0; i < array.Length / 2; i++)
            //{
            //    if (array[i] != array[array.Length - i - 1])
            //    {
            //        isSymetric = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isSymetric);

            ////Reversing an array:

            //int[] array = { 1, 2, 3, 4, 5 };
            //int arrayLength = array.Length;
            //int[] reversedArray = new int[arrayLength];

            //for (int index = 0; index < arrayLength; index++)
            //{
            //    reversedArray[arrayLength - index - 1] = array[index];
            //}

            //for (int index = 0; index < arrayLength; index++)
            //{
            //    Console.WriteLine(reversedArray[index] + " ");
            //}

            ////EXAMPLES:

            //var text = "Hello, I am working. I am busy right now!";

            ////var words = text
            ////    .Split(new char[] { ',', '.', '!', ' ' });

            //var separators = new char[] { ',', '.', '!', ' ' };

            //var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


            ////We have spaces in the array here:
            //var words = text.Split(',', '.', '!', ' ');

            //foreach (var word in words)
            //{
            //    Console.Write(word);
            //}
            //Console.WriteLine();

            ////-----------

            //var alphabet = new char[26];
            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    alphabet[i - 'a'] = i;
            //}

            ////----------

            //var text = "agadgardgadgadgadfgadgagadfga".ToUpper();
            //////Console.WriteLine(text.Length); //29

            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.WriteLine(text[i]);
            //}

            ////Read from Console: 1,2,3,4,5 from strings
            //string text = "1,2,3,4,5";
            //var splitText = text.Split(',');

            //string text2 = "1235";

            //var text2Array = new char[text.Length];

            ////NOT with for each:
            ////foreach (var item in text2)
            ////{

            ////}

            ////NOT quite useful, because string is an array:
            ////for (int i = 0; i < text2.Length; i++)
            ////{
            ////    text2Array[i] = text2[i];
            ////}

            //Console.WriteLine(text[2]);

            ////-------
            ////We need the array to have ints:

            //string text = "1,2,3,4,5";
            //var splitText = text
            //    .Split(',') // "1" | "2" | etc.
            //    .Select(int.Parse)
            //    .ToArray();

            ////The long way:
            //var numbers = new int[splitText.Length];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    var currentText = splitText[i];
            //    var currentNumber = int.Parse(currentText);
            //    numbers[i] = currentNumber;
            //}

            ////-------

            //var numbers = new string[5];
            //Console.WriteLine(numbers[2].Trim()); // error - it cannot delete nothing

            ////-----

            //numbers.Length - gives me the count of elements in the array
            //var numberOfElements = int.Parse(Console.ReadLine());
            ////saving values
            //var numbers = new int[numberOfElements];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i + 1;
            //}

            ////Print numbers from array:
            //Console.WriteLine(numbers); //gives the type of variable in array

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            ////------

            //var numbers = new int[5];
            ////var booleans = new bool[50];

            //numbers[2] = 43;
            //numbers[4] = 67;

            //var secondNumber = numbers[2];

            ////the rest cells will be 0 - the default value

            ////if it is new char = default will print nothing
            ////bool default will be false            

            //Console.WriteLine(numbers[2]);

            ////How we change the original values in the heap in the RAM with reference types:
            //var a = new int[5];
            //var b = a;
            //b[3] = 100;
            //Console.WriteLine(a[3]); // b directs to a, so the array is changed. The array does not clone itself, the change changes the original

            ////IF THE SPACES DO NOT MATTER IN A PROBLEM AND WE WANT TO REMOVE THEM ALL
            //var text = Console.ReadLine().Trim(); - > it trims the last interval ot the line
            //Console.WriteLine(text);

            ////How to split by numerous symbols:
            ////input: 1, 2, 3, 4
            //var text = Console.Readline().Split(new char[] { ' ', ',' }, StringSplitOptions, RemoveEmptyEntries);
            ////is we parse with .Select - Crtl . and we let VS to add LINQ by itself

            ////If we use string result = ""; and then we use For to add - > string result += numbers[i]; - this is SLOW; summing strings is very slow

            //// TO BE MAXIMUM FAST WE USE STRING BUILDER (it's in System.Text):
            //var stringBuilder = new stringBuilder();

            ////EXAMPLE - this cuts the last interval:
            //var numbers = new int[] { 1, 2, 3, 4 };
            //var result = new stringBuilder();
            //for (int i = 0; i < numbers.length; i++)
            //{
            //  result.Append(numbers[i]); - > Append is instead of +=
            // if (i != numbers.Length - 1) result.Append(" "); -> we add empty string
            //}
            // Console.WriteLine(result.ToString()); -> in order to print it

            ////IN THIS CASE they are ints and we can just say: JOIN - Best for printing ARRAYS
            //var result = string.Join(", ", numbers);
            //Console.WriteLine(result); -> this will be without a space at the end

            ////CLONING AN ARRAY
            //var numbers = new int[10];
            ////var secondNumbers = numbers.Clone(); - this returns an object
            ////we can cast it to an array:
            ////var secondNumbers = (int[])numbers.Clone();
            ////Easier way:
            //var secondNumbers = numbers.ToArray();
        }

    }
}
