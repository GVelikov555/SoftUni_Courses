using System;

namespace _04_Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            
            int sum = 0;

            for (int i = 1; i <= numberOfRows; i++)
            {
                string character = Console.ReadLine();
                int digit = character[0];
                sum += digit;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
