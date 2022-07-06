using System;

namespace _02_Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());
                sum+=digit;
            }
            Console.WriteLine(sum);
        }
    }
}
