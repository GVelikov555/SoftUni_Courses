using System;

namespace _03_Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleToLift = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int courseCount = 0;

            while (peopleToLift > 0)
            {
                peopleToLift -= elevatorCapacity;
                courseCount++;
            }
            Console.WriteLine(courseCount);
        }
    }
}
