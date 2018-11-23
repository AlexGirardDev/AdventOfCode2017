using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode2017.Puzzles.Day3
{
    public static class Day3
    {
        public static void Solve()
        {
            Console.WriteLine("===Day 3===");
            var puzzleInput = int.Parse(File.ReadAllText("../../../../Input/Day3.txt"));

            {
                //Part 1
                int[,]
                    array = new int[20_000,
                        20_000]; //This doesnt scale if the number was very large but it was alot easier than having the array grow
                var direction = Direction.Right;


                short x = 10_000;
                short y = 10_000;


                for (int i = 1; i < puzzleInput; i++)
                {

                    switch (direction)
                    {
                        case Direction.Right:
                            array[x, y] = i;
                            x++;
                            if (array[x, y - 1] == 0)
                                direction = Direction.Up;
                            break;
                        case Direction.Up:
                            array[x, y] = i;
                            y--;
                            if (array[x - 1, y] == 0)
                                direction = Direction.Left;
                            break;
                        case Direction.Left:
                            array[x, y] = i;
                            x--;
                            if (array[x, y + 1] == 0)
                                direction = Direction.Down;
                            break;
                        case Direction.Down:
                            array[x, y] = i;
                            y++;
                            if (array[x + 1, y] == 0)
                                direction = Direction.Right;
                            break;
                    }
                }

                var answer = (10_000 - x) + (y - 10_000);
                Console.WriteLine($"Part 1: {answer}");

            }


            {
                //Part 2
                int[,]
                    array = new int[20_000,
                        20_000]; //This doesnt scale if the number was very large but it was alot easier than having the array grow
                var direction = Direction.Right;
                short x = 10_001;
                short y = 10_000;
                array[x, y] = 1;
                var counter = 0;
                var i = 0;
                var values = new List<int>();
                for (; i < puzzleInput;)
                {
                    i = GetAdjacentSum(array, x, y);
                    values.Add(i);
                    counter++;
                    switch (direction)
                    {
                        case Direction.Right:
                            array[x, y] = i;
                            x++;
                            if (array[x, y - 1] == 0)
                                direction = Direction.Up;
                            break;
                        case Direction.Up:
                            array[x, y] = i;
                            y--;
                            if (array[x - 1, y] == 0)
                                direction = Direction.Left;
                            break;
                        case Direction.Left:
                            array[x, y] = i;
                            x--;
                            if (array[x, y + 1] == 0)
                                direction = Direction.Down;
                            break;
                        case Direction.Down:
                            array[x, y] = i;
                            y++;
                            if (array[x + 1, y] == 0)
                                direction = Direction.Right;
                            break;
                    }
                }

                Console.WriteLine($"Part 2: {i}");

            }

        }

        private static int GetAdjacentSum(int[,] array, int x, int y)
        {

            return 
                   array[x - 0, y - 0] + //0
                   array[x - 1, y - 1] + //1
                   array[x - 0, y - 1] + //2
                   array[x + 1, y - 1] + //3
                   array[x + 1, y - 0] + //4
                   array[x + 1, y + 1] + //5
                   array[x + 0, y + 1] + //6
                   array[x - 1, y + 1] + //7
                   array[x - 1, y - 0] ; //8
            //1 2 3
            //8 0 4 
            //7 6 5
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

