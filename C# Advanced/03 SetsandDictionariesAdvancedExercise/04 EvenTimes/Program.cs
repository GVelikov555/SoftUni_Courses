using System;
using System.Collections.Generic;

namespace _04_EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbersOcc = new Dictionary<int, int>();

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbersOcc.ContainsKey(number))
                {
                    numbersOcc.Add(number, 1);
                }
                else
                {
                    numbersOcc[number]++;
                }
            }

            foreach (var entry in numbersOcc)
            {
                if (entry.Value % 2 == 0)
                {
                    Console.WriteLine(entry.Key);
                }
            }
        }
    }
}
