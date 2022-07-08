using System;

namespace _01_Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CompareNums(number);
        }
        static void CompareNums(int num)
        {
            int smallestNum = int.MaxValue;
            int number = num;
            for (int i = 1; i < 4; i++)
            {
                if (number < smallestNum)
                {
                    smallestNum = number;
                }
                if (i < 3)
                {
                    number = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(smallestNum);
        }
    }
}