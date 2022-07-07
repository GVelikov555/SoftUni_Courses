using System;
using System.Linq;

namespace _10_LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldLenght = int.Parse(Console.ReadLine());
            int[] field = new int[fieldLenght];

            int[] bugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int landingPlace = 0; landingPlace < field.Length; landingPlace++)
            {
                for (int buglanded = 0; buglanded < bugs.Length; buglanded++)
                {
                    if (bugs[buglanded] == landingPlace)
                    {
                        field[landingPlace] = 1;
                    }
                }
            }


            string command = Console.ReadLine();

            while (command != "end")
            {
                string [] arrayCommand = command.Split(' ');

                int takeOff = int.Parse(arrayCommand[0]);
                int flyingSteps = int.Parse(arrayCommand[2]);

                if (arrayCommand[1] == "left")
                {
                    for (int landingPlace = 0; landingPlace < field.Length; landingPlace++)
                    {
                        bool stopper = false;

                        if (takeOff == landingPlace & flyingSteps != 0 & field[landingPlace] == 1)
                        {
                            field[landingPlace] = 0;
                            
                            if (flyingSteps > 0)
                            {
                                for (int i = landingPlace; i >= 0; i = i - flyingSteps)
                                {
                                    if (i <= landingPlace - flyingSteps & field[i] != 1)
                                    {
                                        field[i] = 1;
                                        stopper = true;
                                        break;
                                    }
                                }
                            }
                            else if (flyingSteps < 0)
                            {
                                for (int i = landingPlace; i < field.Length; i = i + flyingSteps)
                                {
                                    if (i >= landingPlace - flyingSteps & field[i] != 1)
                                    {
                                        field[i] = 1;
                                        stopper = true;
                                        break ;
                                    }
                                }
                            }
                        }
                        if (stopper)
                        {
                            break;
                        }
                    }
                }
                if (arrayCommand[1] == "right")
                {
                    for (int landingPlace = 0; landingPlace < field.Length; landingPlace++)
                    {
                        bool stopper = false;

                        if (takeOff == landingPlace & flyingSteps != 0 & field[landingPlace] == 1)
                        {
                            field[landingPlace] = 0;

                            if (flyingSteps < 0)
                            {
                                for (int i = landingPlace; i >= 0; i = i - flyingSteps)
                                {
                                    if (i <= landingPlace + flyingSteps & field[i] != 1)
                                    {
                                        field[i] = 1;
                                        stopper = true;
                                        break;
                                    }
                                }
                            }
                            else if (flyingSteps > 0)
                            {
                                for (int i = landingPlace; i < field.Length; i = i + flyingSteps)
                                {
                                    if (i >= landingPlace + flyingSteps & field[i] != 1)
                                    {
                                        field[i] = 1;
                                        stopper = true;
                                        break;
                                    }
                                }
                            }
                        }
                        if (stopper)
                        {
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', field));
        }
    }
}
