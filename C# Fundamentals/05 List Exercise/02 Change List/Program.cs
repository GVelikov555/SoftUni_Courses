using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] separatedCommand = command.Split(' ');
                
                string commandFirst = separatedCommand[0];
                int commandSec = int.Parse(separatedCommand[1]);

                if (commandFirst == "Delete")
                {
                    listOfNumbers.RemoveAll(x => x == commandSec);
                }
                
                else if (commandFirst == "Insert")
                {
                    int commandThird = int.Parse(separatedCommand[2]);
                    listOfNumbers.Insert(commandThird, commandSec);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', listOfNumbers));
        }
    }
}
