using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017.Puzzles.Day2
{
    public static class Day3
    {
        private static readonly List<List<int>> _intList = new List<List<int>>();
        
        public static void Solve()
        {
            Console.WriteLine("===Day 3===");
            var puzzleInput = int.Parse(File.ReadAllText("../../../Input/Day3.txt"));

            {//Part 1
                var direction = Direction.Right;

                _intList.Add(new List<int>{1});
                _intList[0].Add(2);
                int x = 2;
                int y = 0;
                var lol = _intList[0][1];
                for (int i = 2; i < 100; i++)
                {

                    switch (direction)
                    {
                        case Direction.Right:
                            if (y == 0 && x== _intList[x].Count)
                            {
                                _intList.Insert(0, Enumerable.Repeat(0, _intList[x].Count).ToList());
                            }
                            break;
                        case Direction.Up:
                            break;
                        case Direction.Left:
                            break;
                        case Direction.Down:
                            break;
                    }
                }
            }
        }

        private static int GetIntAtIndex(int x, int y)
        {

            return _intList[y][x];
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

