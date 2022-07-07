using System;
using System.Linq;

namespace _08_Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int neededSum = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == neededSum & i != j & i < j)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]} ");
                    }
                }
            }
        }
    }
}
