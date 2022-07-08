using System;

namespace _09_Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            while (num != "END")
            {
                bool isPalindrome = IsTheNumPalindrome(num);

                Console.WriteLine(isPalindrome);
                
                num = Console.ReadLine();
            }
        }
        static bool IsTheNumPalindrome (string num)
        {
            
                string reversedNum = string.Empty;
                bool isPalindrome = false;

                for (int i = num.Length - 1; i > -1; i--)
                {
                    reversedNum += num[i];
                }
                if (reversedNum == num)
                {
                    isPalindrome = true;
                    return isPalindrome;
                }

                return isPalindrome;
        }
    }
}
