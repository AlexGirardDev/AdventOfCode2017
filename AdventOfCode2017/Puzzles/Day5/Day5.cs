using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode2017.Puzzles.Day5
{
    public static class Day5
    {
        public static void Solve()
        {
            Console.WriteLine("===Day 5===");
            var puzzleInput = File.ReadAllLines("../../../../Input/Day5.txt").ToList();

            { //Part 1
                List<int> puzzleList = puzzleInput.Select(int.Parse).ToList();
                int counter = 0;
                int Index = 0;
                while (true)
                {
                    try
                    {
                        int previousIndex = Index;
                        Index = puzzleList[Index] + Index;
                        puzzleList[previousIndex]++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Part 1: {counter}");
                        break;
                    }
                    finally
                    {
                        counter++;
                    }

                }

            }

            { //Part 2
                List<int> puzzleList = puzzleInput.Select(int.Parse).ToList();
                int counter = 0;
                int Index = 0;
                while (true)
                {
                    try
                    {
                        int previousIndex = Index;
                        bool bigOffset = puzzleList[Index] >= 3;
                        Index = puzzleList[Index] + Index;
                        if (bigOffset)
                            puzzleList[previousIndex]--;
                        else
                            puzzleList[previousIndex]++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Part 2: {counter}");
                        break;
                    }
                    finally
                    {
                        counter++;
                    }

                }

            }

        }
    }
}

