using System;
using System.Linq;

namespace _03_Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];


            for (int i = 1; i <= n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    array1[i - 1] = nums[0];
                    array2[i - 1] = nums[1];
                }
                else
                {
                    array1[i - 1] = nums[1];
                    array2[i - 1] = nums[0];
                }
            }
            Console.Write(String.Join(' ', array1));
            Console.WriteLine();
            Console.WriteLine(String.Join(' ', array2));
        }
    }
}
