using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017.Puzzles.Day2
{
    public static class Day3
    {
        public static void Solve()
        {
            Console.WriteLine("===Day 3===");
            var puzzleInput = int.Parse(File.ReadAllText("../../Input/Day3.txt"));

            {//Part 1
             List<List<int>> intList = new List<List<int>>();


                int x = 0;
                int y = 0;
                for (int i = 0; i < 100; i++)
                {
                    
                    if(i)

                }
            }
        }

        public enum Direction
        {
            Right =0,
            Up = 1,
            Left = 2,
            Down = 3
        }
    }
}
