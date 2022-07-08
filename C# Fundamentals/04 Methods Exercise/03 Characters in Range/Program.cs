using System;

namespace _03_Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            string pathBetweenValues = FindAsciiValuesBetweenChars(char1, char2);
            Console.WriteLine(pathBetweenValues);
        }
        static string FindAsciiValuesBetweenChars (char char1, char char2)
        {
            string pathBetweenValues = string.Empty;
            if (char1 < char2)
            {
                for (int i = char1 + 1; i < char2; i++)
                {
                    pathBetweenValues += ($"{(char)i} ");
                }
                return pathBetweenValues;
            }
            else
            {
                for (int i = char2 + 1; i < char1; i++)
                {
                    pathBetweenValues += ($"{(char)i} ");
                }
                return pathBetweenValues;
            }
        }
    }
}
