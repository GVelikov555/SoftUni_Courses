using System;

namespace _2_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                 .Split();
            string first = (input[0]);
            string second = (input[1]);
            char[] firstChar = input[0].ToCharArray();
            char[] secondChar = input[1].ToCharArray();
            long total = 0;

            int minArray = Math.Min(input[0].Length, input[1].Length);
            for (int i = 0; i < minArray; i++)
            {
                long midTotal = firstChar[i] * secondChar[i];
                total += midTotal;
            }
            if (firstChar.Length > secondChar.Length)
            {
                for (int i = 0; i < firstChar.Length - minArray; i++)
                {
                    total += firstChar[i + minArray];
                }
            }
            else
            {
                for (int i = 0; i < second.Length - minArray; i++)
                {
                    total += secondChar[i + minArray];
                }
            }

            Console.WriteLine(total);

        }
    }
}
