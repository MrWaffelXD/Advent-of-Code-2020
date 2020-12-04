using System;

namespace AdventOfCode2020_3._1
{
    class Program
    {
        static int task1()
        {
            string[] map = System.IO.File.ReadAllLines("input.txt");//last char 30 (-31)

            int x = 0, y = 0, trees = 0;

            while (y < map.Length)
            {
                if (map[y][x] == '#')
                {
                    trees++;
                }

                x = x + 3;

                y++;
                if (x > 30)
                {
                    x = x - 31;
                }
            }
            return trees;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("You hit {0} trees.", task1());
        }
    }
}
