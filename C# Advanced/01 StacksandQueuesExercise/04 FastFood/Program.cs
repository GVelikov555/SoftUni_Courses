using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prepairedFood = int.Parse(Console.ReadLine());
            Queue<int> ordersQueue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine(ordersQueue.Max());

            while (ordersQueue.Count > 0)
            {
                if (prepairedFood >= ordersQueue.Peek())
                {
                    prepairedFood -= ordersQueue.Peek();
                    ordersQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
                    break;
                }

            }
            if (ordersQueue.Count == 0)
            {
                Console.WriteLine($"Orders complete");
            }
            
        }
    }
}
