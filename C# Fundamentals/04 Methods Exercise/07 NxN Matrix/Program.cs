using System;

namespace _07_NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

           DrawingWithNums(num);
        }
        static void DrawingWithNums(int num)
        {
            int counter = 0;
            for (int i = 1; i <= num * num; i++)
            {
                counter++;
                if (counter == num)
                {
                    Console.Write(num);
                    Console.Write(" ");
                    Console.WriteLine();
                    counter = 0;
                }
                else
                {
                    Console.Write(num);
                    Console.Write(" ");
                }

            }
        }
    }
}
