using System;
using System.Collections.Generic;

namespace _03_House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfGuests = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int guest = 1; guest <= numOfGuests; guest++)
            {
                string[] guestInfo = Console.ReadLine().Split(' ');
                if (guestInfo[2] != "not")
                {
                    if (!guestList.Contains(guestInfo[0]))
                    {
                        guestList.Add(guestInfo[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{guestInfo[0]} is already in the list!");
                    }
                }
                else
                {
                    if (!guestList.Contains(guestInfo[0]))
                    {
                        Console.WriteLine($"{guestInfo[0]} is not in the list!");
                    }
                    else
                    {
                        guestList.Remove(guestInfo[0]);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}
