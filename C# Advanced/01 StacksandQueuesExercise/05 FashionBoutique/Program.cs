using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pileOfClothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());

            int rackCounter = 0;
            int rackFreeSpace = rackCapacity;

            while (pileOfClothes.Count > 0)
            {
                if (pileOfClothes.Peek() <= rackFreeSpace)
                {
                    rackFreeSpace -= pileOfClothes.Peek();
                    pileOfClothes.Pop();
                    
                    if (rackFreeSpace == 0)
                    {
                        rackCounter++;
                        rackFreeSpace = rackCapacity;
                    }
                    else if (pileOfClothes.Count == 0)
                    {
                        rackCounter++;
                    }
                }
                else
                {
                    rackCounter++;
                    rackFreeSpace = rackCapacity;
                }
            }
            Console.WriteLine(rackCounter);
        }
    }
}
