using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07_TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumpsQueue = new Queue<int[]>();


            for (int i = 0; i < numOfPumps; i++)
            {
                int[] pumpStats = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumpsQueue.Enqueue(pumpStats);
            }

            
            int startIndex = 0;

            for (int i = 0; i < pumpsQueue.Count; i++)
            {
                int totalPetrol = 0;

                foreach (int[] item in pumpsQueue)
                    {
                        int currentLiters = item[0];
                        int currentDistance = item[1];

                    totalPetrol += currentLiters;

                        if (totalPetrol - currentDistance < 0)
                        {
                            startIndex++;
                            int[] currentPump = pumpsQueue.Dequeue();
                            pumpsQueue.Enqueue(currentPump);
                            break;
                        }

                    totalPetrol -= currentDistance;
                    }
            }
            Console.WriteLine(startIndex);
        }
    }
}
