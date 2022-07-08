using System;

namespace _08_Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double fac1 = FacMethod(num1);
            double fac2 = FacMethod(num2);
            //double divideResult = DivideMethod(fac1, fac2);
            double divideResult = (double)fac1 / fac2;
            Console.WriteLine($"{divideResult:f2}");
        }
        static double FacMethod(double num)
        {
            for (double i = Math.Abs(num) - 1; i > 1; i--)
            {
                num *= i;
            }
            return num;
        }
        //static double DivideMethod(int fac1, int fac2)
        //{
        //    return (double)fac1 / fac2;
        //}
    }
}
