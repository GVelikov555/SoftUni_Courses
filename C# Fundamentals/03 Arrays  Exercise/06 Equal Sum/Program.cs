using System;
using System.Linq;

namespace _06_Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int indexLeft = 0; indexLeft < i; indexLeft++)
                {
                    int addLeft = numbers[indexLeft];
                    sumLeft += addLeft; 
                }

                for (int indexRight = numbers.Length - 1; indexRight > i; indexRight--)
                {
                    int addRight = numbers[indexRight];
                    sumRight += addRight;
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }

                sumLeft = 0;
                sumRight = 0;

            }
            Console.WriteLine("no");
        }
    }
}
