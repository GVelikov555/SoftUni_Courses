using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> stackOperational = new Queue<int>();
            int[] info = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int elementsToPush = info[0];
            int elementsToPop = info[1];
            int elementToPeek = info[2];
            int[] numForStack = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < elementsToPush; i++)
            {
                stackOperational.Enqueue(numForStack[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stackOperational.Dequeue();
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
