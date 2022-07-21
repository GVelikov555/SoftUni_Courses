using System;
using System.Collections;
using System.Collections.Generic;

namespace _06_SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsPlaylist = new Queue<string>(Console.ReadLine().Split(", "));

            while (songsPlaylist.Count >  0)
            {
                string cmd = Console.ReadLine();

                if (cmd.StartsWith("Play"))
                {
                    songsPlaylist.Dequeue();
                }
                else if (cmd.StartsWith("Add"))
                {
                    if (!songsPlaylist.Contains(cmd.Substring(4)))
                    {
                        songsPlaylist.Enqueue(cmd.Substring(4));
                    }
                    else
                    {
                        Console.WriteLine($"{cmd.Substring(4)} is already contained!");
                    }
                }
                else if (cmd.StartsWith("Show"))
                {
                    Console.WriteLine(string.Join(", ", songsPlaylist));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
