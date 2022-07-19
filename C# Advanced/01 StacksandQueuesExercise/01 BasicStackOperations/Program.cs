using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackOperational = new Stack<int>();
            int[] info = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int elementsToPush = info[0];
            int elementsToPop = info[1];
            int elementToPeek = info[2];
            int [] numForStack = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < elementsToPush; i++)
            {
                stackOperational.Push(numForStack[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stackOperational.Pop();
            }

            if (stackOperational.Count == 0)
            {
                Console.WriteLine(0);
            }

            else if (stackOperational.Contains(elementToPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stackOperational.Min());
            }


        }
    }
}
