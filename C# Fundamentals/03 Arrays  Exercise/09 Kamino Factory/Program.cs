using System;
using System.Linq;

namespace _09_Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int [] chosenDNA = new int[dnaLength];

            int chosenSum = 0;
            int chosenIndex = dnaLength;
            int chosenLenght = 0;
            int sample = 0;
            int sampleCount = 0;

            while (command != "Clone them!")
            {
                int [] array = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sampleCount++;

                int arraySum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 1)
                    {
                        arraySum++;
                    }
                }

                int arrayLenght = 0;
                int arrayIndex = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 1)
                    {
                        
                        arrayLenght++;
                        
                        if (arrayLenght == 1)
                        {
                            arrayIndex = i;
                        }

                        if (arrayLenght > chosenLenght || arrayLenght == chosenLenght & arrayIndex < chosenIndex || arrayLenght == chosenLenght & arrayIndex == chosenIndex & arraySum > chosenSum)
                        {
                            chosenSum = arraySum;
                            chosenIndex = arrayIndex;
                            chosenLenght = arrayLenght;
                            sample = sampleCount;
                            chosenDNA = array;
                        }
                    }
                    else
                    {
                        arrayLenght = 0;
                        arrayIndex = 0;
                    }
                }
                command = Console.ReadLine();
            }
            if (sample == 0)
            {
                sample = 1;
            }

            Console.WriteLine($"Best DNA sample {sample} with sum: {chosenSum}.");
            Console.WriteLine(String.Join(' ', chosenDNA));
        }
    }
}
