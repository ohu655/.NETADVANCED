using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ");

            Queue<string> songsPlaylist = new Queue<string>(songs);

            while (songsPlaylist.Any())
            {
                string command = Console.ReadLine();
                

                if (command.Contains("Play"))
                {
                    songsPlaylist.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string songName = command.Substring(4);

                    if (!songsPlaylist.Contains(songName))
                    {
                        songsPlaylist.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }                   
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine($"{string.Join(", ", songsPlaylist)}");
                }               
            }

            Console.WriteLine("No more songs!");
        }
    }
}
