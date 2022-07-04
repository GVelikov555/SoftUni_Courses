using System;

namespace _06_Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int refNum = int.Parse(Console.ReadLine());
            int num = refNum;
            int factor = 1;
            int sumFactor = 0;
            while (num >= 1)
            {
                int operNum = num;
                operNum %= 10;
                for (int i = operNum; i > 1; i--)
                {
                    factor *= i;
                }
                num /= 10;
                sumFactor += factor;
                factor = 1;
            }
            if (refNum == sumFactor)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
