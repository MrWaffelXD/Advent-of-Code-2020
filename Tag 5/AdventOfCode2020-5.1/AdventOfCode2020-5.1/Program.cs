using System;

namespace AdventOfCode2020_5._1
{
    class Program
    {
        public static int[] newRange(char c, int[] r)
        {
            int[] result = { 0, 0 };
            if(c == 'F')
            {
                //64-32 = x
                //x/2 = y
                //y+32
                result[0] = r[0];

                int temp = r[1] - r[0];
                temp = temp + 1;
                result[1] = temp / 2;
                result[1] = result[1] - 1;

            }
            else if(c == 'B')
            {
                int temp = r[1] - r[0];
                temp = temp + 1;
                result[0] = temp / 2;
                result[0] = result[0] - 1;
                result[1] = r[1];
            }
            
            return result;
        }
        static void Main(string[] args)
        {
            string[] seats = System.IO.File.ReadAllLines("input.txt");

            string seatDesc = "BFFFBBFRRR";
            int[] range = { 0, 127 };

            range = newRange('F' , range);
            range = newRange('B', range);
            range = newRange('F', range);
            range = newRange('B', range);
        }
    }
}
