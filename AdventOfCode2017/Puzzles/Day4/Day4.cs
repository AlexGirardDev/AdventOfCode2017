using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode2017.Puzzles.Day4
{
    public static class Day4
    {
        public static void Solve()
        {
            Console.WriteLine("===Day 4===");
            var puzzleInput = File.ReadAllLines("../../../../Input/Day4.txt").ToList().Distinct();
            List<List<string>> puzzleList = puzzleInput.Select(s => s.Split(null).ToList()).ToList();

            { //Part 1
                var result = puzzleList.Count- puzzleList.Count(x => x.Distinct().Count() != x.Count);
                //linq feels like cheating 
                Console.WriteLine($"Part 1: {result}");

            }

            { //Part 2
                List<List<string>> puzzleList2 = new List<List<string>>();
                foreach (var p in puzzleList)
                {
                    List<string> stringList = new List<string>();
                    foreach (var  s in p)
                    {
                        stringList.Add(item: String.Concat(s.OrderBy(c => c)));
                    }
                    puzzleList2.Add(stringList);
                }
                var result = puzzleList2.Count - puzzleList2.Count(x => x.OrderBy(y=>y).ToList().Distinct().Count() != x.Count);
                Console.WriteLine($"Part 1: {result}");
            }
        }
    }
}

