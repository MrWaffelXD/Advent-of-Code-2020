using System;

namespace AdventOfCode2020_3._1
{
    class Program
    {
        //slide down a hill and counting trees by map
        static int task1(int xMove = 3, int yMove = 1)
        {
            string[] map = System.IO.File.ReadAllLines("input.txt");//last char 30 (-31)

            int x = 0, y = 0, trees = 0;

            while (y < map.Length)
            {
                if (map[y][x] == '#')
                {
                    trees++;
                }

                x = x + xMove;

                y = y + yMove;
                if (x > 30)
                {
                    x = x - 31;
                }
            }
            return trees;
        }
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("You hit {0} trees.", task1());
            //task2.1
            Int64 total = task1(1, 1);//somehow get out of range values when multiplying in one line
            total = total * task1(3, 1);
            total = total * task1(5, 1);
            total = total * task1(7, 1);
            total = total * task1(1, 2);
            Console.WriteLine("You would hit a total of {0} trees on the slopes.", total);
        }
    }
}
