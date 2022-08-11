using System;
using System.Collections.Generic;

namespace _03_PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                string input = Console.ReadLine();
                string[] chElements = input.Split(" ");
                foreach (string chElement in chElements)
                {
                    elements.Add(chElement);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
