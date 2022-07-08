using System;

namespace _02_Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int returnedResult = VowelsCounter(word);
            Console.WriteLine(returnedResult);
        }
        static int VowelsCounter(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    counter++;
                }
                else if (word[i] == 'A')
                {
                    counter++;
                }
                if (word[i] == 'e')
                {
                    counter++;
                }
                else if (word[i] == 'E')
                {
                    counter++;
                }
                if (word[i] == 'i')
                {
                    counter++;
                }
                else if (word[i] == 'I')
                {
                    counter++;
                }
                if (word[i] == 'o')
                {
                    counter++;
                }
                else if (word[i] == 'O')
                {
                    counter++;
                }
                if (word[i] == 'u')
                {
                    counter++;
                }
                else if (word[i] == 'U')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
