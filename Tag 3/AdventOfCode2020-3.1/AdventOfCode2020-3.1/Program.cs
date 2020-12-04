using System;

namespace AdventOfCode2020_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //193
            string[] map = System.IO.File.ReadAllLines("input.txt");//last char 30 (-31)

            int x = 0, trees = 0;

            for(int y = 0; y < map.Length; y++)
            {
                if (map[y][x] == '#')
                {
                    trees++;
                    Console.Write("Tree at: ");
                }
                Console.WriteLine(y + " / " + x);
                x = x + 3;
                if (x > 30)
                {
                    x = x - 31;
                }
            }
            Console.WriteLine("Total Trees: " + trees);
        }
    }
}
