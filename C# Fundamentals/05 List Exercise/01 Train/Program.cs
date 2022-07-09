using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();
            List<int> trainWagons = info.Split(' ').Select(int.Parse).ToList();
            int maxCapacityWagon = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandLines = command.Split().ToArray();
                string action = commandLines[0];

                if (action == "Add")
                {
                    int toAdd = int.Parse(commandLines[1]);
                    trainWagons.Add(toAdd);
                }
                if (commandLines[commandLines.Length - 1] == commandLines[0])
                {
                    int toAdd = int.Parse(action);
                    int listEnd = trainWagons.Count;
                    
                    for (int i = 0; i < listEnd; i++)
                    {
                        if (trainWagons[i] + toAdd <= maxCapacityWagon)
                        {
                            trainWagons[i] += toAdd;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', trainWagons));
        }
    }
}
