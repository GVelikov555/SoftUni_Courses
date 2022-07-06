using System;

namespace _09_Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sourceCap = int.Parse(Console.ReadLine());

            int storrage = 0;
            int daysWorked = 0;

            for (int i = sourceCap; sourceCap >= 100; daysWorked++)
            {
                storrage += sourceCap;
                sourceCap -= 10;
                storrage -= 26;

                if (storrage < 0)
                {
                    storrage = 0;
                }
            }
            storrage -= 26;

            if (storrage < 0)
            {
                storrage = 0;
            }

            Console.WriteLine(daysWorked);
            Console.WriteLine(storrage);
        }
    }
}
