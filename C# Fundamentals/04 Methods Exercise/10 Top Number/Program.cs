using System;

namespace _10_Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endPoint = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endPoint; i++)
            {
                int isTopInt = TopIntegerFinder(i);
                if (isTopInt != 0)
                {
                    Console.WriteLine(isTopInt);
                };

            }
        }
        static int TopIntegerFinder(int num)
        {
            int testedNum = num;
            int sum = 0;
            int oddCharInNum = 0;
                for (int i = testedNum; i > 0; i = i / 10)
                {
                sum += i % 10;
                if (i % 2 != 0)
                {
                    oddCharInNum++;
                }
                }
            if (sum % 8 == 0 & oddCharInNum > 0)
            {
                return num;
            }
            return 0;
        }
    }
}
