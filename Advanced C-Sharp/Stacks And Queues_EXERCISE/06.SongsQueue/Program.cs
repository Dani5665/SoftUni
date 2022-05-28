using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Queue<string> songList = new Queue<string>();

            foreach (string song in input)
            {
                songList.Enqueue(song);
            }

            while (songList.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.Substring(0 , 3) == "Add")
                {
                    string songName = command.Substring(4);
                    bool listContainsSong = false;
                    foreach (string song in songList)
                    {
                        if (songName == song)
                        {
                            listContainsSong = true;
                        }
                    }
                    if (listContainsSong)
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songList.Enqueue(songName);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ",songList));
                }
                else if (command == "Play")
                {
                    songList.Dequeue();
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
