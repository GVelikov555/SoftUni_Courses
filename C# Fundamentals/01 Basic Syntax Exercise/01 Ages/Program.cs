using System;

namespace _01_Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("baby");
            }
            if (age > 2 && age <= 13)
            {
                Console.WriteLine("child");
            }
            if (age >= 14 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            if (age >= 20 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            if (age >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
