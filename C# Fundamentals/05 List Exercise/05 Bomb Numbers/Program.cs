using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int [] bombArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = bombArray[0];
            int bombPower = bombArray[1];

            for (int index = 0; index < numbers.Count; index++)
            {
                if (numbers[index] == bomb)
                {
                    int explosionRange = bombPower * 2 + 1;
                    int deleteIndex = index - bombPower;


                    if (deleteIndex < 0)
                    {
                        explosionRange += deleteIndex;
                        deleteIndex = 0;
                    }

                    if (deleteIndex + explosionRange >= numbers.Count)
                    {
                        explosionRange = numbers.Count - deleteIndex;
                        numbers.RemoveRange(deleteIndex, explosionRange);
                    }
                    else
                    {
                        numbers.RemoveRange(deleteIndex, explosionRange);
                        index = -1;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
