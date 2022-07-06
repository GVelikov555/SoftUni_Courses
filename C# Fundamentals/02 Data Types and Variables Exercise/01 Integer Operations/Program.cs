using System;

namespace _01_Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int N3 = int.Parse(Console.ReadLine());
            int N4 = int.Parse(Console.ReadLine());

            int sum = N1 + N2;
            int devide = sum / N3;
            int multiply = devide * N4;

            Console.WriteLine(multiply);
        }
    }
}
