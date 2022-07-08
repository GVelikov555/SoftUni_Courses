using System;

namespace _05_Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sumOfOneTwo = SumOfFirstTwoNums(num1, num2);

            int substractThreeFromSum = Substract(sumOfOneTwo, num3);

            Console.WriteLine(substractThreeFromSum);

        }
        static int SumOfFirstTwoNums (int num1, int num2)
        {
            return num1 + num2;
        }
        static int Substract(int sumOfOneTwo, int num3)
        {
            return sumOfOneTwo - num3;
        }
    }
}
