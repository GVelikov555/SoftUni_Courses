using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] analizedCommand = command.Split(' ');

                string mainComm = analizedCommand[0];

                if (mainComm == "Add")
                {
                    int secComm = int.Parse(analizedCommand[1]);

                    listOfNums.Add(secComm);
                }
                else if (mainComm == "Remove")
                {
                    int secComm = int.Parse(analizedCommand[1]);
                    
                    if (secComm < listOfNums.Count & secComm >= 0)
                    {
                        listOfNums.RemoveAt(secComm);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (mainComm == "Insert")
                {
                    int secComm = int.Parse(analizedCommand[1]);
                    int thirdComm = int.Parse(analizedCommand[2]);
                    
                    if (thirdComm < listOfNums.Count & thirdComm >= 0)
                    {
                        listOfNums.Insert(thirdComm, secComm);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (mainComm == "Shift")
                {
                    string secComm = analizedCommand[1];
                    int thirdCommm = int.Parse(analizedCommand[2]);

                    if (secComm == "left")
                    {
                        for (int i = 1; i <= thirdCommm; i++)
                        {
                            listOfNums.Add(listOfNums[0]);
                            listOfNums.RemoveAt(0);
                        }
                    }
                    if (secComm == "right")
                    {
                        for (int i = 1; i <= thirdCommm; i++)
                        {
                            listOfNums.Insert(0, listOfNums[listOfNums.Count - 1]);
                            listOfNums.RemoveAt(listOfNums.Count - 1);
                        }
                    }
                }
                command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine(String.Join(' ', listOfNums));
                }
            }
        }
    }
}
