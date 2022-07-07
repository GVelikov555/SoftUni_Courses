using System;

namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numWagons = int.Parse(Console.ReadLine());
            
            int[] wagonPassangers = new int[numWagons];
            int sum = 0;

            for (int i = 0; i < numWagons; i++)
            {
                wagonPassangers[i] = int.Parse(Console.ReadLine());
                sum += wagonPassangers[i];
            }
            Console.WriteLine(string.Join(' ', wagonPassangers));
            Console.WriteLine(sum);
        }
    }
}
