using System;
using System.Collections.Generic;

namespace AdventOfCode2020_5._1
{
    class Program
    {
        public static int[] newRange(char c, int[] r)
        {
            int[] result = { 0, 0 };
            if(c == 'F' || c== 'L')
            {
                result[0] = r[0];

                int temp = r[1];
                temp = temp - r[0];
                temp = temp / 2;
                temp = temp + r[0];
                result[1] = temp;
            }
            else if(c == 'B' || c== 'R')
            {
                int temp = r[1] - r[0];
                temp = temp / 2;
                temp = temp + r[0];
                result[0] = temp + 1;

                result[1] = r[1];
            }
            return result;
        }
        public static int getMyID(List<int> ids)
        {
            int missing = 0;
            for (int i = 0; i<ids.Count; i++)
            {
                if (ids.Count > ids[i])
                {
                    int curr = ids[i], next = ids[i + 1], nnext = ids[i + 2];

                    if(curr+1 != next)
                    {
                        missing = curr+1;
                    }
                }
            }
            return missing;
        }
        static void Main(string[] args)
        {
            string[] seats = System.IO.File.ReadAllLines("input.txt");
            var ids = new List<int>();

            foreach (var s in seats)
            {
                int[] range = { 0, 127 };
                int[] seat = { 0, 7 };

                for (int i = 0; i<7; i++)
                {
                    range = newRange(s[i], range);
                }
                if(range[0] == range[1])
                {
                    for(int i = 0; i<3; i++)
                    {
                        seat = newRange(s[i+7], seat);
                    }
                    if(seat[0] == seat[1])
                    {
                        int id = range[0] * 8;
                        id = id + seat[0];
                        ids.Add(id);
                        Console.WriteLine("Seat: " + s + " = Row/Column: " + range[0] + "/" + seat[0] + " | ID: " + id);
                    }
                }
            }
            ids.Sort();

            Console.WriteLine("Highest ID: " + ids[ids.Count - 1]);
            Console.WriteLine("Your seat-ID: {0}", getMyID(ids));
        }
    }
}
