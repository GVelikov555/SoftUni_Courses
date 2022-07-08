using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace _11_Array_Manipulator
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();


            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArr = command.Split().ToArray();

                if (commandArr[0] == "exchange")
                {
                    ExchangeAfterIndex(numbers, commandArr);
                }

                else if (commandArr[0] == "max")
                {
                    if (commandArr[1] == "even")
                    {
                        PrintMaxEvenIndex(numbers, evenNumbers);

                    }

                    else if (commandArr[1] == "odd")
                    {
                        PrintMaxOddIndex(numbers, oddNumbers);

                    }
                }

                else if (commandArr[0] == "min")
                {
                    if (commandArr[1] == "even")
                    {
                        PrintMinEvenIndex(numbers, evenNumbers);

                    }

                    else if (commandArr[1] == "odd")
                        PrintMinOddIndex(numbers, oddNumbers);
                }

                else if (commandArr[0] == "first")
                {
                    int counter = int.Parse(commandArr[1]);
                    if (commandArr[2] == "even")
                    {
                        PrintFirstEvenNumber(numbers, counter);

                    }

                    else if (commandArr[2] == "odd")
                        PrintFirstOddNumber(numbers, counter);
                }

                else if (commandArr[0] == "last")
                {
                    int counter = int.Parse(commandArr[1]);

                    if (commandArr[2] == "even")
                    {
                        PrintLastEvenNumbers(numbers, counter);

                    }

                    else if (commandArr[2] == "odd")
                    {
                        PrintLastOddNumbers(numbers, counter);

                    }
                }

                command = Console.ReadLine();
            }

            Console.Write("[");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine("]");
        }


        private static void PrintLastOddNumbers(List<int> numbers, int counter)
        {
            var newListOfOdd = numbers.Where(x => x % 2 != 0).ToList();
            newListOfOdd.Reverse();
            if (counter > numbers.Count)
            {
                Console.WriteLine("Invalid count");
            }

            else if (counter <= numbers.Count && newListOfOdd.Count != 0)
            {
                List<int> newReverseListOfEven = new List<int>().ToList();

                int newCounter = Math.Min(counter, newListOfOdd.Count);
                for (int i = 0; i < newCounter; i++)
                {
                    newReverseListOfEven.Add(newListOfOdd[i]);
                }
                newReverseListOfEven.Reverse();

                Console.Write("[");
                Console.Write(string.Join(", ", newReverseListOfEven));
                Console.WriteLine("]");

            }
            else if (newListOfOdd.Count == 0)
            {
                Console.WriteLine("[]");
            }
        }

        private static void PrintLastEvenNumbers(List<int> numbers, int counter)
        {
            var newListOfeven = numbers.Where(x => x % 2 == 0).ToList();
            newListOfeven.Reverse();


            if (counter > numbers.Count)
            {
                Console.WriteLine("Invalid count");
            }

            else if (counter <= numbers.Count && newListOfeven.Count != 0)
            {
                List<int> newReverseListOfEven = new List<int>().ToList();

                int newCounter = Math.Min(counter, newListOfeven.Count);
                for (int i = 0; i < newCounter; i++)
                {
                    newReverseListOfEven.Add(newListOfeven[i]);
                }
                newReverseListOfEven.Reverse();

                Console.Write("[");
                Console.Write(string.Join(", ", newReverseListOfEven));
                Console.WriteLine("]");

            }
            else if (newListOfeven.Count == 0)
            {
                Console.WriteLine("[]");
            }
        }

        private static void PrintFirstOddNumber(List<int> numbers, int counter)
        {
            var newListOfOdd = numbers.Where(x => x % 2 != 0).ToList();

            if (counter > numbers.Count)
            {
                Console.WriteLine("Invalid count");
            }

            else if (counter <= numbers.Count && newListOfOdd.Count != 0)
            {
                int newCounter = Math.Min(counter, newListOfOdd.Count);
                Console.Write("[");
                for (int i = 0; i < newCounter; i++)
                {

                    if (i == newCounter - 1)
                    {
                        Console.Write(newListOfOdd[i]);
                    }
                    else
                    {
                        Console.Write(newListOfOdd[i] + "," + " ");
                    }
                }
                Console.WriteLine("]");
            }
            else if (newListOfOdd.Count == 0)
            {
                Console.WriteLine("[]");
            }
        }

        private static void PrintFirstEvenNumber(List<int> numbers, int counter)
        {
            var newListOfeven = numbers.Where(x => x % 2 == 0).ToList();

            if (counter > numbers.Count)
            {
                Console.WriteLine("Invalid count");
            }

            else if (counter <= numbers.Count && newListOfeven.Count != 0)
            {
                int newCounter = Math.Min(counter, newListOfeven.Count);
                Console.Write("[");
                for (int i = 0; i < newCounter; i++)
                {

                    if (i == newCounter - 1)
                    {
                        Console.Write(newListOfeven[i]);
                    }
                    else
                    {
                        Console.Write(newListOfeven[i] + "," + " ");
                    }
                }
                Console.WriteLine("]");
            }
            else if (newListOfeven.Count == 0)
            {
                Console.WriteLine("[]");
            }
        }

        private static void PrintMinOddIndex(List<int> numbers, List<int> oddNumbers)
        {
            int minOdd = +2147483647;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] <= minOdd)
                    {
                        oddNumbers.Add(numbers[i]);
                        minOdd = numbers[i];
                    }
                }
            }
            if (oddNumbers.Count > 0)
            {
                Console.WriteLine(numbers.LastIndexOf(minOdd));
            }

            else
            {
                Console.WriteLine("No matches");
            }

        }

        private static void PrintMinEvenIndex(List<int> numbers, List<int> evenNumbers)
        {
            int minEven = 2147483647;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] <= minEven)
                    {
                        evenNumbers.Add(numbers[i]);
                        minEven = numbers[i];

                    }
                }
            }
            if (evenNumbers.Count > 0)
            {
                Console.WriteLine(numbers.LastIndexOf(minEven));
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void PrintMaxOddIndex(List<int> numbers, List<int> oddNumbers)
        {
            int maxOdd = -2147483648;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] >= maxOdd)
                    {
                        oddNumbers.Add(numbers[i]);
                        maxOdd = numbers[i];
                    }
                }
            }
            if (oddNumbers.Count > 0)
            {
                Console.WriteLine(numbers.LastIndexOf(maxOdd));
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void PrintMaxEvenIndex(List<int> numbers, List<int> evenNumbers)
        {
            int maxEven = -2147483648;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                    if (numbers[i] >= maxEven)
                    {
                        maxEven = numbers[i];

                    }
                }
            }
            if (evenNumbers.Count > 0)
            {
                Console.WriteLine(numbers.LastIndexOf(maxEven));
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void ExchangeAfterIndex(List<int> numbers, string[] commandArr)
        {
            int index = int.Parse(commandArr[1]);
            if (index < 0 || index > numbers.Count - 1)
            {
                Console.WriteLine("Invalid index");

            }
            else
            {
                for (int l = 0; l <= index; l++)
                {
                    int a = numbers[0];

                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        numbers[i] = numbers[i + 1];
                    }

                    numbers[numbers.Count - 1] = a;


                }

            }
        }
    }
}