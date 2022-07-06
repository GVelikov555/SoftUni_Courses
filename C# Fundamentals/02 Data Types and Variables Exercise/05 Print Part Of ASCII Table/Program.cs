using System;

namespace _05_Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                string realChar = (Convert.ToChar(i)).ToString();
                Console.Write($"{realChar} ");
            }
        }
    }
}
