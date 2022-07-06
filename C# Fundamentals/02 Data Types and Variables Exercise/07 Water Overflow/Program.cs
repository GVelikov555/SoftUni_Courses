using System;

namespace _07_Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fillingCourses = int.Parse(Console.ReadLine());
            int littersInside = 0;

            for (int i = 0; i < fillingCourses; i++)
            {
                int littersPoured = int.Parse(Console.ReadLine());

                if (littersInside + littersPoured > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    littersInside += littersPoured;
                }

            }
                Console.WriteLine(littersInside);
        }
    }
}
