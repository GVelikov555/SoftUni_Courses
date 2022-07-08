using System;

namespace _06_Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text.Length % 2 == 0)
            {
                string evenMidTxt = MiddleOfEvenTxt(text);

                Console.WriteLine(evenMidTxt);
            }
            else
            {
                string oddMidTxt = MiddleOfOddTxt(text);

                Console.WriteLine(oddMidTxt);
            }
            static string MiddleOfEvenTxt(string text)
            {
                string result= string.Empty;

                for (int i = 0; i < text.Length; i++)
                {
                    if ((text.Length - 1) / 2 == i)
                    {
                        result = text.Substring(i, 2);
                    }
                }

                return result;
            }
            static string MiddleOfOddTxt(string text)
            {
                string result = string.Empty;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Length / 2 == i)
                    {
                        result = text.Substring(i, 1);
                    }
                }

                return result;
            }
        }
    }
}
