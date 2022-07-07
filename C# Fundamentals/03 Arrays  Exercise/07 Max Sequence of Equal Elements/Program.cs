using System;
using System.Linq;

namespace _07_Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int mostRepeatableIndex = 0;
            int pathCounter = 1;
            int longestPath = 1;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (index + 1 >= numbers.Length)
                {
                    break;
                }
                else if (numbers[index] == numbers[index + 1])
                {
                    pathCounter++;
                    if (pathCounter > longestPath)
                    {
                        longestPath = pathCounter;
                        mostRepeatableIndex = numbers[index];
                    }
                }
                else
                {
                    pathCounter = 1;
                }
            }
            for (int i = 0; i < longestPath; i++)
            {
                Console.Write($"{mostRepeatableIndex} ");
            }
        }
    }
}
