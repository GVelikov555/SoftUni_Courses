using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MaximumandMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operations = int.Parse(Console.ReadLine());

            Stack<int> stackOfNums = new Stack<int>();

            for (int i = 0; i < operations; i++)
            {
                int [] cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (cmd[0] == 1)
                {
                    stackOfNums.Push(cmd[1]);
                }
                else if (cmd[0] == 2)
                {
                    stackOfNums.Pop();
                }
                else if (cmd[0] == 3 && stackOfNums.Count != 0)
                {
                    Console.WriteLine(stackOfNums.Max());
                }
                else if (cmd[0] == 4 && stackOfNums.Count != 0)
                {
                    Console.WriteLine(stackOfNums.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stackOfNums));
        }
    }
}
