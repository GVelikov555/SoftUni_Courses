using System;
using System.Linq;

namespace _04_Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());
            int[] rotatedArray = new int[array.Length];
            int compare = array.Length - 1;

            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (numOfRotations >= array.Length)
                {
                    numOfRotations = numOfRotations % array.Length;
                }
                if (i + numOfRotations > compare)
                {
                    rotatedArray[i] = array[j];
                    j++;
                }
                else
                {
                    rotatedArray[i] = array[i + numOfRotations];
                }
            }
            Console.WriteLine(string.Join(' ', rotatedArray));

        }
    }
}
