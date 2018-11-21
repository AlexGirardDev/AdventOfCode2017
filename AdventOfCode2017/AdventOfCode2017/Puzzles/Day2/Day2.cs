using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017.Puzzles.Day2
{
    public static class Day2
    {
        public static void Solve()
        {
            Console.WriteLine("===Day 2===");
            var puzzleInput = File.ReadAllLines("../../Input/Day2.txt");

            var puzzleInputArray = puzzleInput.Select(s => s.Split(null).ToList().Select(x => (int) int.Parse(x)).ToList()).ToList();

            {
                var total = 0;
                foreach (var input in puzzleInputArray)
                {
                    total += input.Max() - input.Min();
                }

                Console.WriteLine($"Part 1: {total}");
            }

        }
    }
}
