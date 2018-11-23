using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2017.Puzzles.Day1
{
    public static class Day1
    {
        public static void Solve()
        {
            Console.WriteLine($"===Day 1===");
            string puzzleInput = File.ReadAllText("../../../Input/Day1.txt");
          

            
            var numberList = puzzleInput.Select(x => (int)Char.GetNumericValue(x)).ToArray();
            var numberTotal = 0;
            for (var index = 0; index < numberList.Length; index++)
            {
                var number = numberList[index];
                var nextNumber = numberList[index >= numberList.Length - 1 ? 0 : index + 1];
                if (number == nextNumber)
                {
                    numberTotal += number;
                }
            }

            Console.WriteLine($"Part 1: {numberTotal}");

        }
    }
}
