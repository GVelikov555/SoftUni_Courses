using System;
using System.Linq;

namespace _05_Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumCount = 0;
            int counter = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                int indexNum = array[i];
                
                for (int j = i + 1; j < array.Length; j++)
                {
                    int indexJ = array[j];
                    
                    if (indexNum <= indexJ)
                    {
                        break;
                    }
                    if (indexNum > indexJ)
                    {
                        sumCount += indexNum;
                    }
                    counter++;
                }

                if (sumCount != 0 && sumCount / counter == indexNum)
                {
                    Console.Write($"{array[i]} ");
                }
                counter = 0;
                sumCount = 0;
            }
            Console.Write($"{array[array.Length - 1]} ");
        }
    }
}
